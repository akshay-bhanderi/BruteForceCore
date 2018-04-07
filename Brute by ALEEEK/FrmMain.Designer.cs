namespace Public_Brute_and_Checker
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.btSource = new MetroFramework.Controls.MetroButton();
			this.btProxy = new MetroFramework.Controls.MetroButton();
			this.cbError = new MetroFramework.Controls.MetroCheckBox();
			this.cbProxy = new MetroFramework.Controls.MetroComboBox();
			this.numThread = new System.Windows.Forms.NumericUpDown();
			this.numTyam = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.lbGood = new System.Windows.Forms.Label();
			this.lbBad = new System.Windows.Forms.Label();
			this.lbError = new System.Windows.Forms.Label();
			this.btStart = new MetroFramework.Controls.MetroButton();
			this.btStop = new MetroFramework.Controls.MetroButton();
			this.textBox1 = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbLeft = new System.Windows.Forms.Label();
			this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
			this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numThread)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTyam)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// btSource
			// 
			this.btSource.Location = new System.Drawing.Point(12, 63);
			this.btSource.Name = "btSource";
			this.btSource.Size = new System.Drawing.Size(229, 23);
			this.btSource.TabIndex = 0;
			this.btSource.Text = "SOURCE";
			this.btSource.Click += new System.EventHandler(this.btSource_Click);
			// 
			// btProxy
			// 
			this.btProxy.Location = new System.Drawing.Point(12, 92);
			this.btProxy.Name = "btProxy";
			this.btProxy.Size = new System.Drawing.Size(229, 23);
			this.btProxy.TabIndex = 1;
			this.btProxy.Text = "PROXY";
			this.btProxy.Click += new System.EventHandler(this.btProxy_Click);
			// 
			// cbError
			// 
			this.cbError.AutoSize = true;
			this.cbError.Checked = true;
			this.cbError.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbError.Location = new System.Drawing.Point(170, 165);
			this.cbError.Name = "cbError";
			this.cbError.Size = new System.Drawing.Size(71, 15);
			this.cbError.TabIndex = 2;
			this.cbError.Text = "REBRUTE";
			this.cbError.UseVisualStyleBackColor = true;
			// 
			// cbProxy
			// 
			this.cbProxy.FormattingEnabled = true;
			this.cbProxy.ItemHeight = 23;
			this.cbProxy.Items.AddRange(new object[] {
            "HTTP/s",
            "SOCKS-4",
            "SOCKS-5"});
			this.cbProxy.Location = new System.Drawing.Point(12, 121);
			this.cbProxy.Name = "cbProxy";
			this.cbProxy.Size = new System.Drawing.Size(229, 29);
			this.cbProxy.TabIndex = 3;
			// 
			// numThread
			// 
			this.numThread.Location = new System.Drawing.Point(12, 195);
			this.numThread.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numThread.Name = "numThread";
			this.numThread.Size = new System.Drawing.Size(105, 20);
			this.numThread.TabIndex = 4;
			this.numThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numThread.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
			// 
			// numTyam
			// 
			this.numTyam.Location = new System.Drawing.Point(124, 195);
			this.numTyam.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numTyam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numTyam.Name = "numTyam";
			this.numTyam.Size = new System.Drawing.Size(118, 20);
			this.numTyam.TabIndex = 5;
			this.numTyam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numTyam.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 266);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 8;
			// 
			// lbGood
			// 
			this.lbGood.AutoSize = true;
			this.lbGood.Location = new System.Drawing.Point(61, 256);
			this.lbGood.Name = "lbGood";
			this.lbGood.Size = new System.Drawing.Size(13, 13);
			this.lbGood.TabIndex = 9;
			this.lbGood.Text = "0";
			// 
			// lbBad
			// 
			this.lbBad.AutoSize = true;
			this.lbBad.Location = new System.Drawing.Point(61, 276);
			this.lbBad.Name = "lbBad";
			this.lbBad.Size = new System.Drawing.Size(13, 13);
			this.lbBad.TabIndex = 10;
			this.lbBad.Text = "0";
			// 
			// lbError
			// 
			this.lbError.AutoSize = true;
			this.lbError.Location = new System.Drawing.Point(61, 294);
			this.lbError.Name = "lbError";
			this.lbError.Size = new System.Drawing.Size(13, 13);
			this.lbError.TabIndex = 11;
			this.lbError.Text = "0";
			// 
			// btStart
			// 
			this.btStart.Location = new System.Drawing.Point(12, 221);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(105, 23);
			this.btStart.TabIndex = 12;
			this.btStart.Text = "Start";
			this.btStart.Click += new System.EventHandler(this.btStart_Click);
			// 
			// btStop
			// 
			this.btStop.Location = new System.Drawing.Point(124, 221);
			this.btStop.Name = "btStop";
			this.btStop.Size = new System.Drawing.Size(118, 23);
			this.btStop.TabIndex = 13;
			this.btStop.Text = "Stop";
			this.btStop.Click += new System.EventHandler(this.btStop_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox1.Location = new System.Drawing.Point(253, 5);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(282, 373);
			this.textBox1.TabIndex = 14;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(76, 348);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(87, 19);
			this.metroLabel1.TabIndex = 15;
			this.metroLabel1.Text = "ALEEEK;SOFT";
			this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 256);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "GOOD";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 276);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "BAD";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 294);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "ERROR";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 316);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "LEFT";
			// 
			// lbLeft
			// 
			this.lbLeft.AutoSize = true;
			this.lbLeft.Location = new System.Drawing.Point(61, 316);
			this.lbLeft.Name = "lbLeft";
			this.lbLeft.Size = new System.Drawing.Size(13, 13);
			this.lbLeft.TabIndex = 20;
			this.lbLeft.Text = "0";
			// 
			// metroCheckBox1
			// 
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.Checked = true;
			this.metroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.metroCheckBox1.Location = new System.Drawing.Point(12, 165);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new System.Drawing.Size(76, 15);
			this.metroCheckBox1.TabIndex = 21;
			this.metroCheckBox1.Text = "Write log?";
			this.metroCheckBox1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.panel1.Controls.Add(this.metroTextBox2);
			this.panel1.Controls.Add(this.metroTextBox1);
			this.panel1.Controls.Add(this.metroButton1);
			this.panel1.Location = new System.Drawing.Point(535, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 315);
			this.panel1.TabIndex = 23;
			// 
			// metroTextBox2
			// 
			this.metroTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
			this.metroTextBox2.Location = new System.Drawing.Point(6, 59);
			this.metroTextBox2.Multiline = true;
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.metroTextBox2.Size = new System.Drawing.Size(275, 256);
			this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Pink;
			this.metroTextBox2.TabIndex = 3;
			// 
			// metroTextBox1
			// 
			this.metroTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
			this.metroTextBox1.Location = new System.Drawing.Point(6, 22);
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.Size = new System.Drawing.Size(163, 23);
			this.metroTextBox1.TabIndex = 1;
			this.metroTextBox1.Text = "test@mail.ru;testpass";
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(178, 19);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(103, 28);
			this.metroButton1.TabIndex = 0;
			this.metroButton1.Text = " TEST";
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel2.Location = new System.Drawing.Point(640, 30);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(83, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Debug Panel";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.Location = new System.Drawing.Point(64, 24);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(129, 25);
			this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
			this.metroLabel3.TabIndex = 24;
			this.metroLabel3.Text = "BruteForceCore";
			// 
			// metroStyleManager1
			// 
			this.metroStyleManager1.Owner = this;
			this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// FrmMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(819, 376);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.metroCheckBox1);
			this.Controls.Add(this.lbLeft);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btStop);
			this.Controls.Add(this.btStart);
			this.Controls.Add(this.lbError);
			this.Controls.Add(this.lbBad);
			this.Controls.Add(this.lbGood);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numTyam);
			this.Controls.Add(this.numThread);
			this.Controls.Add(this.cbProxy);
			this.Controls.Add(this.cbError);
			this.Controls.Add(this.btProxy);
			this.Controls.Add(this.btSource);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmMain";
			this.Resizable = false;
			this.ShowIcon = false;
			this.Style = MetroFramework.MetroColorStyle.Silver;
			this.Theme = MetroFramework.MetroThemeStyle.Light;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
			this.Load += new System.EventHandler(this.FrmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.numThread)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTyam)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btSource;
        private MetroFramework.Controls.MetroButton btProxy;
        private MetroFramework.Controls.MetroCheckBox cbError;
        private MetroFramework.Controls.MetroComboBox cbProxy;
        private System.Windows.Forms.NumericUpDown numThread;
        private System.Windows.Forms.NumericUpDown numTyam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGood;
        private System.Windows.Forms.Label lbBad;
        private System.Windows.Forms.Label lbError;
        private MetroFramework.Controls.MetroButton btStart;
        private MetroFramework.Controls.MetroButton btStop;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLeft;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroTextBox metroTextBox1;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroTextBox metroTextBox2;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Components.MetroStyleManager metroStyleManager1;
		private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
	}
}

