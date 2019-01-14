using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using PCSC;

namespace NFC_Middleware
{
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Main.checkIfRegistriesExist())
            {
                using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Main.REGISTRY_SUBKEY_NAME))

                {

                    if (registryKey != null)

                    {

                        textBoxURL.Text = registryKey.GetValue(Main.REGISTRY_SERVER_URL_KEY).ToString();
                        textBoxRoute.Text = registryKey.GetValue(Main.REGISTRY_API_ROUTE_KEY).ToString();
                        textBoxAPIkey.Text = registryKey.GetValue(Main.REGISTRY_API_KEY).ToString();
                        numericUpDownUserID.Value = Decimal.Parse(registryKey.GetValue(Main.REGISTRY_USER_ID_KEY).ToString());


                        registryKey.Close();

                    }

                }
            }

            var contextFactory = ContextFactory.Instance;
            using (var ctx = contextFactory.Establish(SCardScope.System))
            {
                var readerNames = ctx.GetReaders();
                comboBoxReader.DataSource = readerNames;
            }
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Main.REGISTRY_SUBKEY_NAME);
                if (registryKey == null)
                {
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(Main.REGISTRY_SUBKEY_NAME);
                    key.Close();

                }


                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(Main.REGISTRY_SUBKEY_NAME, true))

                {

                    key.SetValue(Main.REGISTRY_SERVER_URL_KEY, textBoxURL.Text);
                    key.SetValue(Main.REGISTRY_API_ROUTE_KEY, textBoxRoute.Text);
                    key.SetValue(Main.REGISTRY_API_KEY, textBoxAPIkey.Text);
                    key.SetValue(Main.REGISTRY_USER_ID_KEY, numericUpDownUserID.Value.ToString());

                    key.Close();

                }
                MessageBox.Show("Nustatymai išsaugoti. Perkraukite kompiuterį.");
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Įvyko klaida: " + ex.Message);
            }
        }
    }
}
