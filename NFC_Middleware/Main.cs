using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC;
using PCSC.Utils;
using System.Net.Http;
using Microsoft.Win32;

namespace NFC_Middleware
{
    public partial class Main : Form
    {
        //registries variables

        public static string REGISTRY_SUBKEY_NAME = @"SOFTWARE\NFC middleware";
        public static string REGISTRY_API_KEY = "api";
        public static string REGISTRY_API_ROUTE_KEY = "route";
        public static string REGISTRY_READER_KEY = "reader";
        public static string REGISTRY_SERVER_URL_KEY = "server";
        public static string REGISTRY_USER_ID_KEY = "id";

        public static int event_Count = -1;

        public static string READER_NAME = "ACS ACR1252 1S CL Reader PICC 0";
        public static string API_ROUTE = "/api/sendCode/";
    
        public static string API_URL_BUILT = String.Empty;

        public Main()
        {
            InitializeComponent();

            if (checkIfRegistriesExist())
            {
                backgroundNFCListener.RunWorkerAsync();
                ListenerState(backgroundNFCListener.IsBusy);
           
            }
            else
            {
                MessageBox.Show("Nepavyko rasti serverio nustatymų! Norėdami naudotis skaneriu, suveskite serverio nustatymus.");
            }
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            //notifyIcon1.Visible = false;
            
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                //notifyIcon1.Visible = true;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private bool NoReaderFound(ICollection<string> readerNames) => readerNames == null || readerNames.Count < 1;

        private void TransmitBytes()
        {
            // Create a new PC/SC context.
            var ctx = new SCardContext();
            ctx.Establish(SCardScope.System);
            // Connect to the reader
            var rfidReader = new SCardReader(ctx);
            SCardError rc = rfidReader.Connect(
                READER_NAME,
                SCardShareMode.Shared,
                SCardProtocol.T1);
            if (rc != SCardError.Success)
            {
                return;
            }
            // prepare APDU
            byte[] ucByteSend = new byte[]
                {
                    0xFF,   // the instruction class
            		0xCA,   // the instruction code
            		0x00,   // parameter to the instruction
            		0x00,   // parameter to the instruction
            		0x00    // size of I/O transfer
            	};
            rc = rfidReader.BeginTransaction();
            if (rc != SCardError.Success)
            {
                MessageBox.Show("Klaida: nutruko ryšys su skaitytuvu...");
            }
            SCardPCI ioreq = new SCardPCI();   // IO returned protocol control information.
            byte[] ucByteReceive = new byte[10];
            rc = rfidReader.Transmit(
                SCardPCI.T1,// Protocol control information, T0, T1 and Raw
                            // are global defined protocol header structures.
                ucByteSend, // the actual data to be written to the card
                ioreq,      // The returned protocol control information
                ref ucByteReceive);
            if (rc == SCardError.Success)
            {
                var byteList = new List<byte>(ucByteReceive);
                byteList.RemoveRange(byteList.Count - 2, 2);
                ucByteReceive = byteList.ToArray();
                backgroundNFCListener.ReportProgress(0,
                            String.Format(BitConverter.ToString(ucByteReceive).Replace("-","")));
            }
            else
            {
                backgroundNFCListener.ReportProgress(0,
                            String.Format("Klaida: " + SCardHelper.StringifyError(rc)));
            }
            rfidReader.EndTransaction(SCardReaderDisposition.Leave);
            rfidReader.Disconnect(SCardReaderDisposition.Reset);
            ctx.Release();
        }

        public void LogOutput(string output)
        {
            richTextBox1.Text = output + "\n" + richTextBox1.Text;
        }

        private void backgroundNFCListener_DoWork(object sender, DoWorkEventArgs e)
        {
            generateApiUrl();
            var contextFactory = ContextFactory.Instance;
            while (true)
            {
                try
                {
                    using (var ctx = contextFactory.Establish(SCardScope.System))
                    {
                        var readerNames = ctx.GetReaders();

                        if (NoReaderFound(readerNames))
                        {
                            continue;
                        }

                        var readerStates = ctx.GetReaderStatus(READER_NAME);

                        if (readerStates.CardChangeEventCnt != event_Count)
                            TransmitBytes();

                        event_Count = readerStates.CardChangeEventCnt;

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Klaida: " + ex.Message);
                }
            }
        }

        private void backgroundNFCListener_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string code = e.UserState as string;
            LogOutput("Nuskaitytas kodas: "+code);
            SendRequest(code);
        }

        private void ListenerState(bool state)
        {
            if (state)
            {
                labelListenerState.ForeColor = Color.Green;
                labelListenerState.Text = "Veikia";
            }
            else
            {
                labelListenerState.ForeColor = Color.Red;
                labelListenerState.Text = "Neveikia";
            }
        }

        private void backgroundNFCListener_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListenerState(backgroundNFCListener.IsBusy);
        }

        public async Task<string> SendRequest(string code)
        {
            try
            {
                using (var Client = new HttpClient())
                {
                    
                    Uri api = new Uri(API_URL_BUILT+code);
                    Client.DefaultRequestHeaders.Accept.Clear();
                    Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responce = await Client.GetAsync(api);
                    
                    if (responce.IsSuccessStatusCode)
                    {
                        return null;
                    }
                    else
                    {
                        MessageBox.Show("Įvyko klaida siunčiant duomenis į serverį!");
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static bool checkIfRegistriesExist()
        {
            Microsoft.Win32.RegistryKey rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(REGISTRY_SUBKEY_NAME);
            if (rkey == null)
            {
                return false;
            }
            else
                return true;
        }

        private void nustatymaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        public void generateApiUrl()
        {
            string api_url = String.Empty;
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Main.REGISTRY_SUBKEY_NAME))
            {
                if (registryKey != null)
                {
                    var reader = registryKey.GetValue(Main.REGISTRY_READER_KEY);
                    if (reader != null)
                        READER_NAME = reader.ToString();
                    api_url = registryKey.GetValue(Main.REGISTRY_SERVER_URL_KEY).ToString();
                    var route = registryKey.GetValue(Main.REGISTRY_API_ROUTE_KEY);
                    if (route != null)
                        api_url += route.ToString();
                    else
                        api_url += API_ROUTE;
                    api_url += registryKey.GetValue(Main.REGISTRY_API_KEY).ToString();
                    api_url += "/" + registryKey.GetValue(Main.REGISTRY_USER_ID_KEY).ToString() + "/";
                    registryKey.Close();
                }
                else
                {
                    MessageBox.Show("Klaida: nustatymai neteisingi, negalima prisijungti prie serverio!");
                    return;
                }
            }
            API_URL_BUILT = api_url;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            generateApiUrl();
            SendRequest("123456");
        }

        private void buttonShowUrl_Click(object sender, EventArgs e)
        {
            generateApiUrl();
            MessageBox.Show(API_URL_BUILT);
        }

        private void buttonReloadWorker_Click(object sender, EventArgs e)
        {
            backgroundNFCListener.CancelAsync(); ;
        }

        private void informacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }


        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void išjungtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ar tikrai norite išjungti programą?", "Išjungti", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (checkIfRegistriesExist())
            {
                notifyIcon1.Visible = true;
                this.WindowState = FormWindowState.Minimized;
                Hide();
                
                
            }
        }
    }
}
