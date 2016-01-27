using System.Windows.Forms;
namespace SuperSpam
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.StopSpam = new System.Windows.Forms.Button();
            this.VersionInfoLabel = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.EngineChoser = new System.Windows.Forms.ComboBox();
            this.speed = new System.Windows.Forms.Label();
            this.SpeedControl = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuperSpamEngine = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.afteller = new System.Windows.Forms.Timer(this.components);
            this.OldSuperSpamEngine = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstOpenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstOpslaanAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.debuggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterToetsVerzendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlinehelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overSuperSpamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweVersieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ThemePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.StartSpam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.secretStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedControl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ThemePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ControlPanel.Controls.Add(this.webBrowser1);
            this.ControlPanel.Controls.Add(this.StartSpam);
            this.ControlPanel.Controls.Add(this.StopSpam);
            this.ControlPanel.Controls.Add(this.VersionInfoLabel);
            this.ControlPanel.Controls.Add(this.Counter);
            this.ControlPanel.Controls.Add(this.EngineChoser);
            this.ControlPanel.Controls.Add(this.speed);
            this.ControlPanel.Controls.Add(this.SpeedControl);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 24);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(551, 27);
            this.ControlPanel.TabIndex = 2;
            this.ControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(386, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(36, 20);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // StopSpam
            // 
            this.StopSpam.BackColor = System.Drawing.SystemColors.Control;
            this.StopSpam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StopSpam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopSpam.ForeColor = System.Drawing.Color.Black;
            this.StopSpam.Location = new System.Drawing.Point(57, 3);
            this.StopSpam.Name = "StopSpam";
            this.StopSpam.Size = new System.Drawing.Size(54, 23);
            this.StopSpam.TabIndex = 2;
            this.StopSpam.Text = "Stop";
            this.StopSpam.UseVisualStyleBackColor = false;
            this.StopSpam.Click += new System.EventHandler(this.button4_Click);
            // 
            // VersionInfoLabel
            // 
            this.VersionInfoLabel.AutoSize = true;
            this.VersionInfoLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.VersionInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionInfoLabel.Location = new System.Drawing.Point(485, 0);
            this.VersionInfoLabel.Name = "VersionInfoLabel";
            this.VersionInfoLabel.Size = new System.Drawing.Size(66, 12);
            this.VersionInfoLabel.TabIndex = 6;
            this.VersionInfoLabel.Text = "Made by: Marf";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.Location = new System.Drawing.Point(126, 4);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(19, 20);
            this.Counter.TabIndex = 10;
            this.Counter.Text = "5";
            this.Counter.Visible = false;
            // 
            // EngineChoser
            // 
            this.EngineChoser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EngineChoser.FormattingEnabled = true;
            this.EngineChoser.Items.AddRange(new object[] {
            "Engine 1",
            "Engine 2 (sloom)"});
            this.EngineChoser.Location = new System.Drawing.Point(353, 4);
            this.EngineChoser.Name = "EngineChoser";
            this.EngineChoser.Size = new System.Drawing.Size(79, 21);
            this.EngineChoser.TabIndex = 11;
            this.EngineChoser.Text = "Engine 1";
            this.EngineChoser.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // speed
            // 
            this.speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(211, 8);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(51, 13);
            this.speed.TabIndex = 3;
            this.speed.Text = "Snelheid:";
            // 
            // SpeedControl
            // 
            this.SpeedControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedControl.Location = new System.Drawing.Point(268, 4);
            this.SpeedControl.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.SpeedControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeedControl.Name = "SpeedControl";
            this.SpeedControl.Size = new System.Drawing.Size(79, 20);
            this.SpeedControl.TabIndex = 4;
            this.SpeedControl.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SpeedControl.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SuperSpamEngine
            // 
            this.SuperSpamEngine.Tick += new System.EventHandler(this.SuperSpamEngine_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 295);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // afteller
            // 
            this.afteller.Interval = 1000;
            this.afteller.Tick += new System.EventHandler(this.afteller_Tick);
            // 
            // OldSuperSpamEngine
            // 
            this.OldSuperSpamEngine.Interval = 500;
            this.OldSuperSpamEngine.Tick += new System.EventHandler(this.OldSuperSpamEngine_Tick);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "SuperSpam";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon2_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.instellingenToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.nieuweVersieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem,
            this.tekstOpenenToolStripMenuItem,
            this.tekstOpslaanAlsToolStripMenuItem,
            this.themasToolStripMenuItem,
            this.toolStripSeparator2,
            this.debuggerToolStripMenuItem,
            this.secretStuffToolStripMenuItem,
            this.toolStripSeparator1,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nieuwToolStripMenuItem.Text = "Nieuw";
            this.nieuwToolStripMenuItem.Click += new System.EventHandler(this.nieuwToolStripMenuItem_Click);
            // 
            // tekstOpenenToolStripMenuItem
            // 
            this.tekstOpenenToolStripMenuItem.Name = "tekstOpenenToolStripMenuItem";
            this.tekstOpenenToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tekstOpenenToolStripMenuItem.Text = "Openen";
            this.tekstOpenenToolStripMenuItem.Click += new System.EventHandler(this.tekstOpenenToolStripMenuItem_Click);
            // 
            // tekstOpslaanAlsToolStripMenuItem
            // 
            this.tekstOpslaanAlsToolStripMenuItem.Name = "tekstOpslaanAlsToolStripMenuItem";
            this.tekstOpslaanAlsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tekstOpslaanAlsToolStripMenuItem.Text = "Opslaan als";
            this.tekstOpslaanAlsToolStripMenuItem.Click += new System.EventHandler(this.tekstOpslaanAlsToolStripMenuItem_Click);
            // 
            // themasToolStripMenuItem
            // 
            this.themasToolStripMenuItem.Name = "themasToolStripMenuItem";
            this.themasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.themasToolStripMenuItem.Text = "Thema\'s";
            this.themasToolStripMenuItem.Click += new System.EventHandler(this.themasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // debuggerToolStripMenuItem
            // 
            this.debuggerToolStripMenuItem.Name = "debuggerToolStripMenuItem";
            this.debuggerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.debuggerToolStripMenuItem.Text = "Debug Info";
            this.debuggerToolStripMenuItem.Click += new System.EventHandler(this.debuggerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // instellingenToolStripMenuItem
            // 
            this.instellingenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterToetsVerzendenToolStripMenuItem,
            this.gameToetsToolStripMenuItem});
            this.instellingenToolStripMenuItem.Name = "instellingenToolStripMenuItem";
            this.instellingenToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.instellingenToolStripMenuItem.Text = "Instellingen";
            // 
            // enterToetsVerzendenToolStripMenuItem
            // 
            this.enterToetsVerzendenToolStripMenuItem.Checked = true;
            this.enterToetsVerzendenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enterToetsVerzendenToolStripMenuItem.Name = "enterToetsVerzendenToolStripMenuItem";
            this.enterToetsVerzendenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.enterToetsVerzendenToolStripMenuItem.Text = "Enter toets verzenden";
            this.enterToetsVerzendenToolStripMenuItem.Click += new System.EventHandler(this.enterToetsVerzendenToolStripMenuItem_Click);
            // 
            // gameToetsToolStripMenuItem
            // 
            this.gameToetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.gameToetsToolStripMenuItem.Enabled = false;
            this.gameToetsToolStripMenuItem.Name = "gameToetsToolStripMenuItem";
            this.gameToetsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gameToetsToolStripMenuItem.Text = "Game toets ";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "key";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlinehelpToolStripMenuItem,
            this.overSuperSpamToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // onlinehelpToolStripMenuItem
            // 
            this.onlinehelpToolStripMenuItem.Enabled = false;
            this.onlinehelpToolStripMenuItem.Name = "onlinehelpToolStripMenuItem";
            this.onlinehelpToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.onlinehelpToolStripMenuItem.Text = "Online-help";
            // 
            // overSuperSpamToolStripMenuItem
            // 
            this.overSuperSpamToolStripMenuItem.Name = "overSuperSpamToolStripMenuItem";
            this.overSuperSpamToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.overSuperSpamToolStripMenuItem.Text = "Over SuperSpam";
            this.overSuperSpamToolStripMenuItem.Click += new System.EventHandler(this.overSuperSpamToolStripMenuItem_Click);
            // 
            // nieuweVersieToolStripMenuItem
            // 
            this.nieuweVersieToolStripMenuItem.Name = "nieuweVersieToolStripMenuItem";
            this.nieuweVersieToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.nieuweVersieToolStripMenuItem.Text = "Nieuwe Versie 0.0";
            this.nieuweVersieToolStripMenuItem.Visible = false;
            this.nieuweVersieToolStripMenuItem.Click += new System.EventHandler(this.nieuweVersieToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel1.Text = "Lijn:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel4.Text = "Engine Gestopt";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "1777 Theme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Default Theme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(5, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "DarkTheme";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ThemePanel
            // 
            this.ThemePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel.Controls.Add(this.checkBox3);
            this.ThemePanel.Controls.Add(this.checkBox2);
            this.ThemePanel.Controls.Add(this.checkBox1);
            this.ThemePanel.Controls.Add(this.button6);
            this.ThemePanel.Controls.Add(this.button3);
            this.ThemePanel.Controls.Add(this.panel3);
            this.ThemePanel.Controls.Add(this.button1);
            this.ThemePanel.Controls.Add(this.button5);
            this.ThemePanel.Controls.Add(this.button2);
            this.ThemePanel.Location = new System.Drawing.Point(12, 88);
            this.ThemePanel.Name = "ThemePanel";
            this.ThemePanel.Size = new System.Drawing.Size(144, 255);
            this.ThemePanel.TabIndex = 17;
            this.ThemePanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 21);
            this.panel3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Experimental stuff";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Record Mouse Pos\r\n";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Play Mouse Macro";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // StartSpam
            // 
            this.StartSpam.BackColor = System.Drawing.SystemColors.Control;
            this.StartSpam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartSpam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartSpam.Image = ((System.Drawing.Image)(resources.GetObject("StartSpam.Image")));
            this.StartSpam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartSpam.Location = new System.Drawing.Point(3, 3);
            this.StartSpam.Name = "StartSpam";
            this.StartSpam.Size = new System.Drawing.Size(48, 23);
            this.StartSpam.TabIndex = 1;
            this.StartSpam.Text = "Start";
            this.StartSpam.UseVisualStyleBackColor = false;
            this.StartSpam.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperSpam.Properties.Resources.close_button;
            this.pictureBox1.Location = new System.Drawing.Point(122, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Enable Console";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(6, 196);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Allow GC";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(5, 219);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(92, 17);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "Multithreading";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // secretStuffToolStripMenuItem
            // 
            this.secretStuffToolStripMenuItem.Name = "secretStuffToolStripMenuItem";
            this.secretStuffToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.secretStuffToolStripMenuItem.Text = "Experimental Stuff";
            this.secretStuffToolStripMenuItem.Click += new System.EventHandler(this.secretStuffToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(551, 368);
            this.Controls.Add(this.ThemePanel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SuperSpam_Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedControl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ThemePanel.ResumeLayout(false);
            this.ThemePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown SpeedControl;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Button StopSpam;
        private System.Windows.Forms.Button StartSpam;
        private System.Windows.Forms.Timer SuperSpamEngine;
        private System.Windows.Forms.Label VersionInfoLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private RichTextBox textBox1;
        private Label Counter;
        private Timer afteller;
        private ComboBox EngineChoser;
        private Timer OldSuperSpamEngine;
        private NotifyIcon notifyIcon2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bestandToolStripMenuItem;
        private ToolStripMenuItem tekstOpenenToolStripMenuItem;
        private ToolStripMenuItem tekstOpslaanAlsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem onlinehelpToolStripMenuItem;
        private ToolStripMenuItem overSuperSpamToolStripMenuItem;
        private ToolStripMenuItem debuggerToolStripMenuItem;
        private ToolStripMenuItem nieuwToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem nieuweVersieToolStripMenuItem;
        private ToolStripMenuItem instellingenToolStripMenuItem;
        private ToolStripMenuItem enterToetsVerzendenToolStripMenuItem;
        private ToolStripMenuItem gameToetsToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private Button button1;
        private Button button2;
        private Button button5;
        private Panel ThemePanel;
        private Panel panel3;
        private ToolStripMenuItem themasToolStripMenuItem;
        private Button button6;
        private Button button3;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ToolStripMenuItem secretStuffToolStripMenuItem;
    }
}

