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
            this.StartSpam = new System.Windows.Forms.Button();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstOpenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstOpslaanAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.debuggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crashSuperSpamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterToetsVerzendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.enableRandomIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.topMinBottomMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.enableDisableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.allowBetaUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlinehelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overSuperSpamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superSpamScriptingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicSansModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweVersieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MouseEngine = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MouseRecorder = new System.Windows.Forms.Timer(this.components);
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nederlandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedControl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.Control;
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
            // 
            // StartSpam
            // 
            this.StartSpam.BackColor = System.Drawing.SystemColors.Control;
            this.StartSpam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartSpam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartSpam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartSpam.Location = new System.Drawing.Point(77, 2);
            this.StartSpam.Name = "StartSpam";
            this.StartSpam.Size = new System.Drawing.Size(67, 23);
            this.StartSpam.TabIndex = 1;
            this.StartSpam.Text = "Start (F12)";
            this.StartSpam.UseVisualStyleBackColor = false;
            this.StartSpam.Click += new System.EventHandler(this.button3_Click);
            // 
            // StopSpam
            // 
            this.StopSpam.BackColor = System.Drawing.SystemColors.Control;
            this.StopSpam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StopSpam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopSpam.ForeColor = System.Drawing.Color.Black;
            this.StopSpam.Location = new System.Drawing.Point(4, 2);
            this.StopSpam.Name = "StopSpam";
            this.StopSpam.Size = new System.Drawing.Size(67, 23);
            this.StopSpam.TabIndex = 2;
            this.StopSpam.Text = "Stop (F11)";
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
            this.Counter.Location = new System.Drawing.Point(170, 4);
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
            "Engine 2"});
            this.EngineChoser.Location = new System.Drawing.Point(353, 3);
            this.EngineChoser.Name = "EngineChoser";
            this.EngineChoser.Size = new System.Drawing.Size(79, 21);
            this.EngineChoser.TabIndex = 11;
            this.EngineChoser.Text = "Engine 1";
            // 
            // speed
            // 
            this.speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(217, 7);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(45, 13);
            this.speed.TabIndex = 3;
            this.speed.Text = "Interval:";
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
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 263);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "";
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.instellingenToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.nieuweVersieToolStripMenuItem,
            this.BuildToolStripMenuItem});
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
            this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem,
            this.loadArrayToolStripMenuItem,
            this.tekstOpenenToolStripMenuItem,
            this.tekstOpslaanAlsToolStripMenuItem,
            this.toolStripSeparator2,
            this.debuggerToolStripMenuItem,
            this.toolStripSeparator1,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.bestandToolStripMenuItem.Text = "File";
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nieuwToolStripMenuItem.Text = "New";
            this.nieuwToolStripMenuItem.Click += new System.EventHandler(this.nieuwToolStripMenuItem_Click);
            // 
            // readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem
            // 
            this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Name = "readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem";
            this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Text = ".";
            this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Visible = false;
            this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Click += new System.EventHandler(this.readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem_Click);
            // 
            // loadArrayToolStripMenuItem
            // 
            this.loadArrayToolStripMenuItem.Name = "loadArrayToolStripMenuItem";
            this.loadArrayToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadArrayToolStripMenuItem.Text = "Load Array";
            this.loadArrayToolStripMenuItem.Click += new System.EventHandler(this.loadArrayToolStripMenuItem_Click);
            // 
            // tekstOpenenToolStripMenuItem
            // 
            this.tekstOpenenToolStripMenuItem.Name = "tekstOpenenToolStripMenuItem";
            this.tekstOpenenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tekstOpenenToolStripMenuItem.Text = "Open File";
            this.tekstOpenenToolStripMenuItem.Click += new System.EventHandler(this.tekstOpenenToolStripMenuItem_Click);
            // 
            // tekstOpslaanAlsToolStripMenuItem
            // 
            this.tekstOpslaanAlsToolStripMenuItem.Name = "tekstOpslaanAlsToolStripMenuItem";
            this.tekstOpslaanAlsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tekstOpslaanAlsToolStripMenuItem.Text = "Save file as";
            this.tekstOpslaanAlsToolStripMenuItem.Click += new System.EventHandler(this.tekstOpslaanAlsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(130, 6);
            // 
            // debuggerToolStripMenuItem
            // 
            this.debuggerToolStripMenuItem.Name = "debuggerToolStripMenuItem";
            this.debuggerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.debuggerToolStripMenuItem.Text = "Debug Info";
            this.debuggerToolStripMenuItem.Click += new System.EventHandler(this.debuggerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.afsluitenToolStripMenuItem.Text = "Exit";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crashSuperSpamToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Visible = false;
            // 
            // crashSuperSpamToolStripMenuItem
            // 
            this.crashSuperSpamToolStripMenuItem.Name = "crashSuperSpamToolStripMenuItem";
            this.crashSuperSpamToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.crashSuperSpamToolStripMenuItem.Text = "Crash SuperSpam";
            this.crashSuperSpamToolStripMenuItem.Click += new System.EventHandler(this.crashSuperSpamToolStripMenuItem_Click);
            // 
            // instellingenToolStripMenuItem
            // 
            this.instellingenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.enterToetsVerzendenToolStripMenuItem,
            this.randomIntervalToolStripMenuItem,
            this.gameToetsToolStripMenuItem,
            this.toolStripSeparator5,
            this.allowBetaUpdatesToolStripMenuItem});
            this.instellingenToolStripMenuItem.Name = "instellingenToolStripMenuItem";
            this.instellingenToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.instellingenToolStripMenuItem.Text = "Settings";
            // 
            // enterToetsVerzendenToolStripMenuItem
            // 
            this.enterToetsVerzendenToolStripMenuItem.Checked = true;
            this.enterToetsVerzendenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enterToetsVerzendenToolStripMenuItem.Name = "enterToetsVerzendenToolStripMenuItem";
            this.enterToetsVerzendenToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.enterToetsVerzendenToolStripMenuItem.Text = "Send Enter keypress after every line";
            this.enterToetsVerzendenToolStripMenuItem.Click += new System.EventHandler(this.enterToetsVerzendenToolStripMenuItem_Click);
            // 
            // randomIntervalToolStripMenuItem
            // 
            this.randomIntervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator3,
            this.toolStripTextBox2,
            this.toolStripSeparator4,
            this.enableRandomIntervalToolStripMenuItem,
            this.toolStripSeparator6,
            this.topMinBottomMaxToolStripMenuItem});
            this.randomIntervalToolStripMenuItem.Name = "randomIntervalToolStripMenuItem";
            this.randomIntervalToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.randomIntervalToolStripMenuItem.Text = "Random Interval";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "500";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "1000";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(212, 6);
            // 
            // enableRandomIntervalToolStripMenuItem
            // 
            this.enableRandomIntervalToolStripMenuItem.Name = "enableRandomIntervalToolStripMenuItem";
            this.enableRandomIntervalToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.enableRandomIntervalToolStripMenuItem.Text = "Enable Random Interval";
            this.enableRandomIntervalToolStripMenuItem.Click += new System.EventHandler(this.enableRandomIntervalToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(212, 6);
            // 
            // topMinBottomMaxToolStripMenuItem
            // 
            this.topMinBottomMaxToolStripMenuItem.Enabled = false;
            this.topMinBottomMaxToolStripMenuItem.Name = "topMinBottomMaxToolStripMenuItem";
            this.topMinBottomMaxToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.topMinBottomMaxToolStripMenuItem.Text = "Top = Min. Bottom = Max.";
            // 
            // gameToetsToolStripMenuItem
            // 
            this.gameToetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3,
            this.enableDisableToolStripMenuItem});
            this.gameToetsToolStripMenuItem.Name = "gameToetsToolStripMenuItem";
            this.gameToetsToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.gameToetsToolStripMenuItem.Text = "Game key (WIP)";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "T";
            // 
            // enableDisableToolStripMenuItem
            // 
            this.enableDisableToolStripMenuItem.Name = "enableDisableToolStripMenuItem";
            this.enableDisableToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.enableDisableToolStripMenuItem.Text = "Enable/Disable";
            this.enableDisableToolStripMenuItem.Click += new System.EventHandler(this.enableDisableToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(262, 6);
            // 
            // allowBetaUpdatesToolStripMenuItem
            // 
            this.allowBetaUpdatesToolStripMenuItem.Name = "allowBetaUpdatesToolStripMenuItem";
            this.allowBetaUpdatesToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.allowBetaUpdatesToolStripMenuItem.Text = "Opt-in for Beta/Pre-Release Updates";
            this.allowBetaUpdatesToolStripMenuItem.Click += new System.EventHandler(this.allowBetaUpdatesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlinehelpToolStripMenuItem,
            this.overSuperSpamToolStripMenuItem,
            this.superSpamScriptingToolStripMenuItem,
            this.comicSansModeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // onlinehelpToolStripMenuItem
            // 
            this.onlinehelpToolStripMenuItem.Enabled = false;
            this.onlinehelpToolStripMenuItem.Name = "onlinehelpToolStripMenuItem";
            this.onlinehelpToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.onlinehelpToolStripMenuItem.Text = "Online help";
            // 
            // overSuperSpamToolStripMenuItem
            // 
            this.overSuperSpamToolStripMenuItem.Name = "overSuperSpamToolStripMenuItem";
            this.overSuperSpamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.overSuperSpamToolStripMenuItem.Text = "About SuperSpam";
            this.overSuperSpamToolStripMenuItem.Click += new System.EventHandler(this.overSuperSpamToolStripMenuItem_Click);
            // 
            // superSpamScriptingToolStripMenuItem
            // 
            this.superSpamScriptingToolStripMenuItem.Name = "superSpamScriptingToolStripMenuItem";
            this.superSpamScriptingToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.superSpamScriptingToolStripMenuItem.Text = "SuperSpam Scripting";
            this.superSpamScriptingToolStripMenuItem.Click += new System.EventHandler(this.superSpamScriptingToolStripMenuItem_Click);
            // 
            // comicSansModeToolStripMenuItem
            // 
            this.comicSansModeToolStripMenuItem.Name = "comicSansModeToolStripMenuItem";
            this.comicSansModeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.comicSansModeToolStripMenuItem.Text = "Comic Sans Police";
            this.comicSansModeToolStripMenuItem.Visible = false;
            this.comicSansModeToolStripMenuItem.Click += new System.EventHandler(this.comicSansModeToolStripMenuItem_Click);
            // 
            // nieuweVersieToolStripMenuItem
            // 
            this.nieuweVersieToolStripMenuItem.Name = "nieuweVersieToolStripMenuItem";
            this.nieuweVersieToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.nieuweVersieToolStripMenuItem.Text = "New Version: 0.0";
            this.nieuweVersieToolStripMenuItem.Visible = false;
            this.nieuweVersieToolStripMenuItem.Click += new System.EventHandler(this.nieuweVersieToolStripMenuItem_Click);
            // 
            // BuildToolStripMenuItem
            // 
            this.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem";
            this.BuildToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.BuildToolStripMenuItem.Text = "New Build: 000";
            this.BuildToolStripMenuItem.Visible = false;
            this.BuildToolStripMenuItem.Click += new System.EventHandler(this.BuildToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "Status_text";
            // 
            // alertTimer
            // 
            this.alertTimer.Interval = 200;
            this.alertTimer.Tick += new System.EventHandler(this.alertTimer_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(514, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 295);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Normal / MultiLine";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Array";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(537, 227);
            this.listBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 36);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(248, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Edit Selected";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(346, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Random";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(167, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(543, 269);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(349, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 78);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(404, 253);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check out my Github page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 156);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Version text";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SuperSpam.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Loading. Please Wait.";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.nederlandsToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // nederlandsToolStripMenuItem
            // 
            this.nederlandsToolStripMenuItem.Name = "nederlandsToolStripMenuItem";
            this.nederlandsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nederlandsToolStripMenuItem.Text = "Nederlands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(551, 368);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperSpam_title_bar_text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedControl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private RichTextBox textBox1;
        private Label Counter;
        private Timer afteller;
        private ComboBox EngineChoser;
        private Timer OldSuperSpamEngine;
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
        private ToolStripMenuItem superSpamScriptingToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Timer alertTimer;
        private Button button1;
        private ToolStripMenuItem randomIntervalToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem enableRandomIntervalToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private CheckBox checkBox1;
        private Timer MouseEngine;
        private ToolStripMenuItem comicSansModeToolStripMenuItem;
        private ToolStripMenuItem readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage tabPage4;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button5;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem allowBetaUpdatesToolStripMenuItem;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label4;
        private ToolStripMenuItem BuildToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem topMinBottomMaxToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripMenuItem enableDisableToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem crashSuperSpamToolStripMenuItem;
        private Timer MouseRecorder;
        private ToolStripMenuItem loadArrayToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem nederlandsToolStripMenuItem;
    }
}

