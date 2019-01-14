namespace NFC_Middleware
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nustatymaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.atidarytiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nustatymaiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.išjungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundNFCListener = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelListenerState = new System.Windows.Forms.Label();
            this.buttonShowUrl = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nustatymaiToolStripMenuItem,
            this.informacijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nustatymaiToolStripMenuItem
            // 
            this.nustatymaiToolStripMenuItem.Name = "nustatymaiToolStripMenuItem";
            this.nustatymaiToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.nustatymaiToolStripMenuItem.Text = "Nustatymai";
            this.nustatymaiToolStripMenuItem.Click += new System.EventHandler(this.nustatymaiToolStripMenuItem_Click);
            // 
            // informacijaToolStripMenuItem
            // 
            this.informacijaToolStripMenuItem.Name = "informacijaToolStripMenuItem";
            this.informacijaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.informacijaToolStripMenuItem.Text = "Informacija";
            this.informacijaToolStripMenuItem.Click += new System.EventHandler(this.informacijaToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(163, 27);
            this.richTextBox1.MaxLength = 214;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(339, 332);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NFC";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atidarytiToolStripMenuItem,
            this.nustatymaiToolStripMenuItem1,
            this.išjungtiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 70);
            // 
            // atidarytiToolStripMenuItem
            // 
            this.atidarytiToolStripMenuItem.Name = "atidarytiToolStripMenuItem";
            this.atidarytiToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.atidarytiToolStripMenuItem.Text = "Atidaryti";
            this.atidarytiToolStripMenuItem.Click += new System.EventHandler(this.atidarytiToolStripMenuItem_Click);
            // 
            // nustatymaiToolStripMenuItem1
            // 
            this.nustatymaiToolStripMenuItem1.Name = "nustatymaiToolStripMenuItem1";
            this.nustatymaiToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.nustatymaiToolStripMenuItem1.Text = "Nustatymai";
            this.nustatymaiToolStripMenuItem1.Click += new System.EventHandler(this.nustatymaiToolStripMenuItem_Click);
            // 
            // išjungtiToolStripMenuItem
            // 
            this.išjungtiToolStripMenuItem.Name = "išjungtiToolStripMenuItem";
            this.išjungtiToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.išjungtiToolStripMenuItem.Text = "Išjungti";
            this.išjungtiToolStripMenuItem.Click += new System.EventHandler(this.išjungtiToolStripMenuItem_Click);
            // 
            // backgroundNFCListener
            // 
            this.backgroundNFCListener.WorkerReportsProgress = true;
            this.backgroundNFCListener.WorkerSupportsCancellation = true;
            this.backgroundNFCListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundNFCListener_DoWork);
            this.backgroundNFCListener.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundNFCListener_ProgressChanged);
            this.backgroundNFCListener.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundNFCListener_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelListenerState);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skanerio procesas";
            // 
            // labelListenerState
            // 
            this.labelListenerState.AutoSize = true;
            this.labelListenerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListenerState.ForeColor = System.Drawing.Color.Red;
            this.labelListenerState.Location = new System.Drawing.Point(7, 21);
            this.labelListenerState.Name = "labelListenerState";
            this.labelListenerState.Size = new System.Drawing.Size(70, 16);
            this.labelListenerState.TabIndex = 0;
            this.labelListenerState.Text = "Neveikia";
            // 
            // buttonShowUrl
            // 
            this.buttonShowUrl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowUrl.Location = new System.Drawing.Point(13, 288);
            this.buttonShowUrl.Name = "buttonShowUrl";
            this.buttonShowUrl.Size = new System.Drawing.Size(132, 23);
            this.buttonShowUrl.TabIndex = 4;
            this.buttonShowUrl.Text = "Rodyti URL";
            this.buttonShowUrl.UseVisualStyleBackColor = true;
            this.buttonShowUrl.Click += new System.EventHandler(this.buttonShowUrl_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTest.Location = new System.Drawing.Point(13, 244);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(132, 23);
            this.buttonTest.TabIndex = 5;
            this.buttonTest.Text = "Testuoti ryšį";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 371);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonShowUrl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ToolTracker - NFC middleware";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundNFCListener;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelListenerState;
        private System.Windows.Forms.ToolStripMenuItem nustatymaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijaToolStripMenuItem;
        private System.Windows.Forms.Button buttonShowUrl;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.ToolStripMenuItem atidarytiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nustatymaiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem išjungtiToolStripMenuItem;
    }
}

