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
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuperSpamEngine = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.afteller = new System.Windows.Forms.Timer(this.components);
            this.trololol = new System.Windows.Forms.Timer(this.components);
            this.OldSuperSpamEngine = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstOpenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstOpslaanAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.debuggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterToetsVerzendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.superSpamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superSpamHtmlFlooderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superSpamEMailFlooserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superSpamWebViewSimulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlinehelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overSuperSpamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweVersieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 27);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(57, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Made by: Marf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "5";
            this.label6.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Engine 1",
            "Engine 2 (sloom)"});
            this.comboBox1.Location = new System.Drawing.Point(376, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Engine 1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Snelheid:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(291, 7);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 317);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "";
            // 
            // afteller
            // 
            this.afteller.Interval = 1000;
            this.afteller.Tick += new System.EventHandler(this.afteller_Tick);
            // 
            // trololol
            // 
            this.trololol.Tick += new System.EventHandler(this.trololol_Tick);
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
            this.superSpamToolStripMenuItem,
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
            this.toolStripSeparator2,
            this.debuggerToolStripMenuItem,
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // debuggerToolStripMenuItem
            // 
            this.debuggerToolStripMenuItem.Name = "debuggerToolStripMenuItem";
            this.debuggerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.debuggerToolStripMenuItem.Text = "Debug";
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
            // superSpamToolStripMenuItem
            // 
            this.superSpamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.superSpamHtmlFlooderToolStripMenuItem,
            this.superSpamEMailFlooserToolStripMenuItem,
            this.superSpamWebViewSimulatorToolStripMenuItem});
            this.superSpamToolStripMenuItem.Name = "superSpamToolStripMenuItem";
            this.superSpamToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.superSpamToolStripMenuItem.Text = "Programma\'s";
            // 
            // superSpamHtmlFlooderToolStripMenuItem
            // 
            this.superSpamHtmlFlooderToolStripMenuItem.Name = "superSpamHtmlFlooderToolStripMenuItem";
            this.superSpamHtmlFlooderToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.superSpamHtmlFlooderToolStripMenuItem.Text = "SuperSpam Html Flooder";
            this.superSpamHtmlFlooderToolStripMenuItem.Click += new System.EventHandler(this.superSpamHtmlFlooderToolStripMenuItem_Click);
            // 
            // superSpamEMailFlooserToolStripMenuItem
            // 
            this.superSpamEMailFlooserToolStripMenuItem.Name = "superSpamEMailFlooserToolStripMenuItem";
            this.superSpamEMailFlooserToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.superSpamEMailFlooserToolStripMenuItem.Text = "SuperSpam E-Mail Flooder";
            // 
            // superSpamWebViewSimulatorToolStripMenuItem
            // 
            this.superSpamWebViewSimulatorToolStripMenuItem.Name = "superSpamWebViewSimulatorToolStripMenuItem";
            this.superSpamWebViewSimulatorToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.superSpamWebViewSimulatorToolStripMenuItem.Text = "SuperSpam Web-View Simulator";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(551, 368);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SuperSpam C# Port Codename: ²";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer SuperSpamEngine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private RichTextBox textBox1;
        private Label label6;
        private Timer afteller;
        private Timer trololol;
        private ComboBox comboBox1;
        private Timer OldSuperSpamEngine;
        private NotifyIcon notifyIcon2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bestandToolStripMenuItem;
        private ToolStripMenuItem tekstOpenenToolStripMenuItem;
        private ToolStripMenuItem tekstOpslaanAlsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ToolStripMenuItem superSpamToolStripMenuItem;
        private ToolStripMenuItem superSpamHtmlFlooderToolStripMenuItem;
        private ToolStripMenuItem superSpamEMailFlooserToolStripMenuItem;
        private ToolStripMenuItem superSpamWebViewSimulatorToolStripMenuItem;
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
    }
}

