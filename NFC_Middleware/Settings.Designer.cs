namespace NFC_Middleware
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRoute = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxAPIkey = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDownUserID = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxReader = new System.Windows.Forms.ComboBox();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserID)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxURL);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serverio adresas";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(7, 17);
            this.textBoxURL.MaxLength = 150;
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(246, 20);
            this.textBoxURL.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRoute);
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 43);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "API nuoroda (route)";
            // 
            // textBoxRoute
            // 
            this.textBoxRoute.Location = new System.Drawing.Point(6, 17);
            this.textBoxRoute.MaxLength = 150;
            this.textBoxRoute.Name = "textBoxRoute";
            this.textBoxRoute.Size = new System.Drawing.Size(247, 20);
            this.textBoxRoute.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxAPIkey);
            this.groupBox3.Location = new System.Drawing.Point(12, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 43);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "API raktas";
            // 
            // textBoxAPIkey
            // 
            this.textBoxAPIkey.Location = new System.Drawing.Point(7, 17);
            this.textBoxAPIkey.MaxLength = 150;
            this.textBoxAPIkey.Name = "textBoxAPIkey";
            this.textBoxAPIkey.Size = new System.Drawing.Size(247, 20);
            this.textBoxAPIkey.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownUserID);
            this.groupBox4.Location = new System.Drawing.Point(12, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 43);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vartotojo identifikacinis numeris";
            // 
            // numericUpDownUserID
            // 
            this.numericUpDownUserID.Location = new System.Drawing.Point(8, 17);
            this.numericUpDownUserID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownUserID.Name = "numericUpDownUserID";
            this.numericUpDownUserID.Size = new System.Drawing.Size(246, 20);
            this.numericUpDownUserID.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxReader);
            this.groupBox5.Location = new System.Drawing.Point(12, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 43);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RFID skaitytuvas";
            // 
            // comboBoxReader
            // 
            this.comboBoxReader.FormattingEnabled = true;
            this.comboBoxReader.Location = new System.Drawing.Point(6, 16);
            this.comboBoxReader.Name = "comboBoxReader";
            this.comboBoxReader.Size = new System.Drawing.Size(245, 21);
            this.comboBoxReader.TabIndex = 0;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveSettings.Location = new System.Drawing.Point(100, 278);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSettings.TabIndex = 5;
            this.buttonSaveSettings.Text = "Išsaugoti";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Nustatymai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserID)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRoute;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxAPIkey;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDownUserID;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxReader;
        private System.Windows.Forms.Button buttonSaveSettings;
    }
}