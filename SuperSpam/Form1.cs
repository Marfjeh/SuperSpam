/*
 * I'm so sorry to watch you being in pain because of this badly written code.
 * And how the hell did you got the source code? o_O
 * Marf is not a real C# programmer, he has made this in his own time because his friends needed a program like this. 
 * Do not hit Marf because of this. Marf has done no harm to you.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using WindowsInput;
using System.IO;
using System.Web;
using System.Configuration;
using System.Net;
using System.Xml.Linq;
using System.Reflection;

namespace SuperSpam
{

    public partial class Form1 : Form
    {
        int a, b;
        Process currentProc = Process.GetCurrentProcess();

        // Version Info
        string versie = "2.6.0";
        int version_int = 260;

        // Build info
        int buildnum = 309;
        string buildtype = "Release";
        string builddate = "15-9-2016";
        string codename = "2 Years";

        //Update System
        string updateserver = "http://www.marfprojects.nl/projects/Super/SuperSpam.exe";
        string updateserverpre = "http://www.marfprojects.nl/projects/Super/pre.exe";

        string server = "http://www.marfprojects.nl/projects/Super/index.php";
        public string new_version = "";
        public string new_build = "";
        public string new_version_int = "";
        public Boolean Buildupdater = false; //Allowing Beta/Pre-Release Updates.

        public Boolean ingorealert = false; //Allowing users to ingore alerts after pressing X.

        //Kill Switch
        string kill = "1";
        string new_date = "";

        //Debugging
        Boolean in64now = Environment.Is64BitProcess;
        Boolean Debug_mode = false;

        //See how many cpu cores there is, maybe useful for multithreading in the future
        string cpus = Environment.ProcessorCount.ToString();
        public int tabcontrolgeselecteerd = 0;
        //end

        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (SpeedControl.Enabled == true)
            {
                int interval = Convert.ToInt32(SpeedControl.Value);
                debuglog("Engine snelheid: " + interval.ToString(), "info");
                SuperSpamEngine.Interval = interval;
                OldSuperSpamEngine.Interval = interval;
                if (interval < 100)
                {
                    statusalert("Speed below 100ms can make programs unstable/laggy!", true, true);
                }
                else
                {
                    statusalert(null, false, false);
                }
            }
        }

        private void statusalert(string message, Boolean warningicon, Boolean flash)
        {
            if (ingorealert == false)
            {
                if (flash == true)
                {
                    //alertTimer.Enabled = true;
                    button1.Visible = true;
                    toolStripStatusLabel1.ForeColor = Color.Red;
                }
                else
                {
                    //alertTimer.Enabled = false;
                    button1.Visible = false;
                    toolStripStatusLabel1.ForeColor = Color.Black;
                }

                if (warningicon == true)
                {
                    toolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                }
                else
                {
                    toolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
                }

                if (message == "" || message == null)
                {
                    toolStripStatusLabel1.Text = "SuperSpam " + versie;
                    toolStripStatusLabel1.ForeColor = Color.Black;
                    button1.Visible = false;
                }
                else
                {
                    toolStripStatusLabel1.Text = message;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabcontrolgeselecteerd == 0 && textBox1.Text == "")
            {
                MessageBox.Show("You cant spam if you dont have anything in the textbox...", "SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tabcontrolgeselecteerd == 1 && listBox1.Items.Count == 0)
            {
                MessageBox.Show("Your Array is empty.", "SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(tabcontrolgeselecteerd == 2)
            {
                
            }
            else
            {
                EngineChoser.Enabled = false;
                Counter.Visible = true;
                afteller.Enabled = true;
                debuglog("SuperSpam " + EngineChoser.Text + " Begint. Wacht 5 seconden...", "Engine");
                if (tabcontrolgeselecteerd == 1)
                {
                    listBox1.SelectedIndex = 0;
                }

            }
        }

        private void arrayspam()
        {
            if (tabcontrolgeselecteerd == 1)
            {

                if (EngineChoser.Text == "Engine 1")
                {
                    try
                    {
                        InputSimulator.SimulateTextEntry((string)listBox1.SelectedItem);
                        if (enterToetsVerzendenToolStripMenuItem.Checked == true)
                        { InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN); }

                        if (checkBox1.Checked == false)
                        {
                            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                        }
                        else
                        {
                            Random random = new Random();
                            int randomNumber = random.Next(0, listBox1.Items.Count);
                            listBox1.SelectedIndex = randomNumber;
                        }
                    }
                    catch
                    {
                        if (checkBox1.Checked == false)
                        {
                            listBox1.SelectedIndex = 0;
                        }
                        else
                        {
                            Random random = new Random();
                            int randomNumber = random.Next(0, listBox1.Items.Count);
                            listBox1.SelectedIndex = randomNumber;
                        }
                    }
                }
            }
            else
            {
                try
                {
                    SendKeys.Send((string)listBox1.SelectedItem);
                    if (enterToetsVerzendenToolStripMenuItem.Checked == true)
                    {
                        SendKeys.Send("{ENTER}");
                    }
                    if (checkBox1.Checked == false)
                    {
                        listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    }
                    else
                    {
                        Random random = new Random();
                        int randomNumber = random.Next(0, listBox1.Items.Count);
                        listBox1.SelectedIndex = randomNumber;
                    }
                }
                catch
                {
                    listBox1.SelectedIndex = 0;
                }
            }
        }


        private void SuperSpamEngine_Tick(object sender, EventArgs e)
        {
            if (tabcontrolgeselecteerd == 0)
            {
                if (enterToetsVerzendenToolStripMenuItem.Checked == true)
                {
                    InputSimulator.SimulateTextEntry(textBox1.Text);
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
                }
                else
                {
                    InputSimulator.SimulateTextEntry(textBox1.Text);
                }
            }
            else
            {
                arrayspam();
            }

            if (enableRandomIntervalToolStripMenuItem.Checked == true)
            {
                randominterval();
            }

            if (enableDisableToolStripMenuItem.Checked == true)
            {
                gamekey();
            }
        }

        private void randominterval()
        {
            int min = Convert.ToInt32(toolStripTextBox1.Text);
            int max = Convert.ToInt32(toolStripTextBox2.Text);
            Random r = new Random();
            int rInt = r.Next(min, max);
            SpeedControl.Value = rInt;

            SuperSpamEngine.Interval = rInt;
            OldSuperSpamEngine.Interval = rInt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            debuglog("SuperSpam " + EngineChoser.Text + " Gestopt.", "Engine");
            EngineChoser.Enabled = true;
            SuperSpamEngine.Enabled = false;
            OldSuperSpamEngine.Enabled = false;
            afteller.Enabled = false;
            Counter.Text = "5";
            Counter.Visible = false;
            ram_clean();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "SuperSpam Version: " + versie + " Build: " + buildnum + " Codename: " + codename;
            toolStripStatusLabel1.Text = "SuperSpam " + versie;
            debuglog("SuperSpam Bootstrapper Started.", "info");
            debuglog("SuperSpam " + versie + " Build: " + buildnum + " " + buildtype, "info");
            this.Text = "SuperSpam " + versie;
            VersionInfoLabel.Text = "Made by: Marf Ver: " + versie;
            stop_gui();
            int interval = Convert.ToInt32(SpeedControl.Value);
            SuperSpamEngine.Interval = interval;
            if (Debug_mode == false)
            {
                superspam_updater(null);
            }
            else
            {
                this.Text = "SuperSpam 2 ver: " + versie + " Build: " + buildnum + " " + buildtype + " " + builddate + " DEBUG MODE";
                start_gui();
                debuglog("Superspam draait in debug mode", "WARNING");
                debugToolStripMenuItem.Visible = true;
            }
            debuglog("Begint met verbinden van de server...", "Activatie_thread");
            if (Buildupdater == true)
            {
                allowBetaUpdatesToolStripMenuItem.Checked = true;
                allowBetaUpdatesToolStripMenuItem.Tag = "Enabled by default because this is an pre-release/beta build.";
            }

        }

        public void superspam_updater(string argument)
        {
            if (Debug_mode == false)
            {
                try
                {
                    string HTML;
                    using (var wc = new WebClient()) // met using kunnen we de downloadstream gelijk sluiten als het klaar is.
                    {
                        HTML = wc.DownloadString(server + "?version=" + versie + "&dev=" + Convert.ToInt32(Buildupdater));
                    }
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(HTML);

                    //Parsing data from server
                    new_version = doc.GetElementbyId("new_version").InnerText;
                    kill = doc.GetElementbyId("Kill_Switch").InnerText;
                    new_date = doc.GetElementbyId("date").InnerText;
                    new_build = doc.GetElementbyId("beta_build").InnerText;
                    new_version_int = doc.GetElementbyId("new_version_int").InnerText;
                    int killer = Convert.ToInt32(kill);
                    debuglog("Loaded.", "Activatie_thread2.0");
                    if (killer == 1)
                    {
                        MessageBox.Show("Kill switch is activated. SuperSpam is Useless, maybe this version is outdated.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        this.Close();
                    }
                    else
                    {
                        start_gui();
                        ram_clean();
                        debuglog("Versie is geaccepteerd, Killswitch is niet actief. Start gui", "Activatie_thread");

                    }

                    // update checker
                    int old_v = version_int;
                    int new_v = int.Parse(new_version_int);
                    int new_b = int.Parse(new_build);

                    debuglog("Checkt voor nieuwe versie...", "Activatie_thread");

                    if (old_v == new_v)
                    {
                        // Geen nieuwe Versie gevonden!
                        debuglog("Er is geen nieuwe versie gevonden. Versie online: " + new_version + " Deze versie: " + versie, "info");
                    }
                    else if (old_v >= new_v)
                    {
                        VersionInfoLabel.Text = "Versie: " + versie + " Build: " + buildnum + "\n Development Version";
                        debuglog("Hoi marf :)", "Activatie_thread");
                    }
                    else
                    {
                        // Nieuwe versie gevonden!
                        nieuweVersieToolStripMenuItem.Text = "Nieuwe Update: " + new_version;
                        nieuweVersieToolStripMenuItem.Visible = true;
                        debuglog("Nieuwe versie gevonden, " + new_version, "Activatie_thread");

                    }
                    debuglog("Versie online: " + new_version + " Deze versie: " + versie, "info");
                    if (Buildupdater == true)
                    {
                        if (buildnum == int.Parse(new_build)) // geen nieuwe update gevonden
                        {
                            BuildToolStripMenuItem.Visible = false;
                        }
                        else if (buildnum >= int.Parse(new_build)) // deze versie is hoger dan die op de server staat.
                        {
                            BuildToolStripMenuItem.Visible = true;
                            BuildToolStripMenuItem.Text = "debug: " + buildnum.ToString() + " Server: " + new_build;
                        }
                        else
                        {
                            BuildToolStripMenuItem.Visible = true;
                            BuildToolStripMenuItem.Text = "New Build: " + new_build;
                        }
                    }

                }
                catch (Exception b)
                {
                    errorhandler.ShowError(b.ToString(), "There's problem when connecting to the server. SuperSpam will close now.");
                    this.Close();
                }
            }
            else
            {
                this.Text = "SuperSpam 2 ver: " + versie + " Build: " + buildnum + " " + buildtype + " " + builddate + " DEBUG MODE";
                start_gui();
                debuglog("Superspam draait in debug mode", "WARNING");
            }
        }

        public void stop_gui()
        {
            ControlPanel.Visible = false;
            menuStrip1.Visible = false;
            tabControl1.Visible = false;
            statusStrip1.Visible = false;
        }

        public void start_gui()
        {
            ControlPanel.Visible = true;
            tabControl1.Visible = true;
            menuStrip1.Visible = true;
            statusStrip1.Visible = true;

        }

        public void enablecontrolp(int setting)
        {
            if (setting == 1)
            {
                StopSpam.Enabled = true;
                StartSpam.Enabled = true;
                SpeedControl.Enabled = true;
                EngineChoser.Enabled = true;
            }
            else
            {
                StopSpam.Enabled = false;
                StartSpam.Enabled = false;
                SpeedControl.Enabled = false;
                EngineChoser.Enabled = false;
            }
        }

        private void afteller_Tick(object sender, EventArgs e)
        {
            int aftel = Convert.ToInt32(Counter.Text);

            if (aftel == 0)
            {
                afteller.Enabled = false;
                Counter.Text = "5";
                if (EngineChoser.Text == "Engine 1")
                {
                    SuperSpamEngine.Enabled = true;
                }
                else
                {
                    OldSuperSpamEngine.Enabled = true;
                }
                Counter.Visible = false;
            }
            else
            {
                aftel = aftel - 1;
                Counter.Text = Convert.ToString(aftel);
            }
        }

        public void ram_clean()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            long memory = GC.GetTotalMemory(true);
            debuglog("GC uitgevoerd.", "Info");
        }

        public void debuglog(string e, string a)
        {
            string tijd = DateTime.Now.ToString("HH:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            Debug.WriteLine("[" + tijd + "|" + a + "] " + e);

        }

        private void OldSuperSpamEngine_Tick(object sender, EventArgs e)
        {
            if (tabcontrolgeselecteerd == 0)
            {
                if (enterToetsVerzendenToolStripMenuItem.Checked == true)
                {
                    try
                    {
                        SendKeys.Send(textBox1.Text + "{ENTER}");
                    }
                    catch
                    {
                        SuperSpamEngine.Enabled = false;
                        MessageBox.Show("Syntax Error! See Help > SuperSpam Scripting for help.", "SuperSpam Scripting Engine", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    try
                    {
                        SendKeys.Send(textBox1.Text);
                    }
                    catch
                    {
                        SuperSpamEngine.Enabled = false;
                        MessageBox.Show("Syntax Error! See Help > SuperSpam Scripting for help.", "SuperSpam Scripting Engine", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            else
            {
                arrayspam();
            }
            if (enableRandomIntervalToolStripMenuItem.Checked == true)
            {
                randominterval();
            }
        }

        private void tekstOpenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open a txt file";
            openFileDialog1.Filter = "Txt file (*.txt) | *.txt";
            openFileDialog1.AddExtension = false;
            openFileDialog1.ShowDialog();
            try { textBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText); } catch { }
            ram_clean();
        }

        private void tekstOpslaanAlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save as txt";
            saveFileDialog1.Filter = "Txt file (*.txt) | *.txt";
            saveFileDialog1.AddExtension = false;
            saveFileDialog1.ShowDialog();
            try { textBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText); }
            catch { }
            ram_clean();
        }

        private void overSuperSpamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void nieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "SuperSpam", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                textBox1.Text = "";
                listBox1.Items.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void debuggerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            long memoryUsed = currentProc.PrivateMemorySize64;
            long naarmb = 1024 * 1024;
            MessageBox.Show("------------------DEBUG------------------\n"
                + "\nBuild in: C#"
                + "\nBuild: " + buildnum
                + "\nbuild type: " + buildtype
                + "\nbuild date: " + builddate
                + "\nWindows Version: " + System.Environment.OSVersion
                + "\n64Bit process: " + in64now
                + "\nCpu count: " + cpus
                + "\nDebug mode: " + Debug_mode
                + "\nSpamEngine in use: " + EngineChoser.Text
                + "\nSpamEngine Status: " + SuperSpamEngine.Enabled.ToString()
                + "\nSpamEngine Interval: " + SuperSpamEngine.Interval.ToString()
                + "\nSuperSpam Memory usage: " + memoryUsed / naarmb + " MB. Bytes: " + memoryUsed, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void nieuweVersieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(updateserver);
        }

        private void enterToetsVerzendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enterToetsVerzendenToolStripMenuItem.Checked == false)
            {
                enterToetsVerzendenToolStripMenuItem.Checked = true;
            }
            else
            {
                enterToetsVerzendenToolStripMenuItem.Checked = false;
            }
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alertTimer_Tick(object sender, EventArgs e)
        {
            button1.Visible = true;
            toolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            if (toolStripStatusLabel1.ForeColor == Color.Red)
            {
                toolStripStatusLabel1.ForeColor = Color.Black;
            }
            else
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusalert(null, false, false);
            ingorealert = true;
        }

        private void enableRandomIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enableRandomIntervalToolStripMenuItem.Checked == false)
            {
                enableRandomIntervalToolStripMenuItem.Checked = true;
                SpeedControl.Enabled = false;
            }
            else
            {
                enableRandomIntervalToolStripMenuItem.Checked = false;
                SpeedControl.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Add text to the array", "SuperSpam", null);
            if (promptValue != null || promptValue != "")
            {
                listBox1.Items.Add(promptValue);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nothing selected to delete!", "SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.last_tab = tabcontrolgeselecteerd;
            SuperSpamEngine.Enabled = false;
            OldSuperSpamEngine.Enabled = false;
            switch (tabControl1.SelectedIndex)
            {
                case 0: //classic Text
                    {
                        tabcontrolgeselecteerd = 0;
                        tekstOpslaanAlsToolStripMenuItem.Enabled = true;
                        tekstOpenenToolStripMenuItem.Enabled = true;
                        readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Visible = false;
                        readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Text = "none";
                        enablecontrolp(1);
                    }
                    break;
                case 1: // Array
                    {
                        tabcontrolgeselecteerd = 1;
                        tekstOpslaanAlsToolStripMenuItem.Enabled = false;
                        tekstOpenenToolStripMenuItem.Enabled = false;
                        readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Visible = true;
                        readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Text = "Save Array";
                        enablecontrolp(1);
                    }
                    break;
                case 2: // Whatsapp typing...
                    {
                        tabcontrolgeselecteerd = 2;
                        enablecontrolp(1);
                    }
                    break;
                case 3: // About
                    {
                        tabcontrolgeselecteerd = 3;
                        enablecontrolp(0);
                    }
                    break;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                int selected = listBox1.SelectedIndex;
                string data = Prompt.ShowDialog("Edit Selected", "SuperSpam", (string)listBox1.SelectedItem);
                listBox1.Items.RemoveAt(selected);
                listBox1.Items.Insert(selected, data);
            }
            else
            {
                MessageBox.Show("Nothing selected to edit!", "SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Marfjeh");
        }

        private void allowBetaUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allowBetaUpdatesToolStripMenuItem.Checked == true)
            {
                allowBetaUpdatesToolStripMenuItem.Checked = false;
                Buildupdater = false;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to opt-in for Development builds?\nThey are not guraranteed to be stable, and contains bugs.\n\nIf you want to submit a bug report or even an suggestion/idea, please visit http://www.sweetnyancraft.nl/SuperSpam \nAfter pressing yes, Superspam will connect to the server and check for a new build", "SuperSpam Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    allowBetaUpdatesToolStripMenuItem.Checked = true;
                    Buildupdater = true;
                    superspam_updater(null);
                }
                else if (dialogResult == DialogResult.No)
                {
                    allowBetaUpdatesToolStripMenuItem.Checked = false;
                    Buildupdater = false;
                }
            }
        }

        private void BuildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(updateserverpre);
        }

        private void crashSuperSpamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int lol = 1;
            int lol2 = 0;
            int total = lol / lol2;
        }

        public void gamekey()
        {
            string textfromtextbox = toolStripTextBox3.Text;
            switch (textfromtextbox.ToUpper()) //not as efficent, but it works. Generated by a Simple Php script :P
            {
                case "Q":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_Q);
                    break;
                case "W":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_W);
                    break;
                case "E":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_E);
                    break;
                case "R":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_R);
                    break;
                case "T":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_T);
                    break;
                case "Y":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_Y);
                    break;
                case "U":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_U);
                    break;
                case "I":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_I);
                    break;
                case "O":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_O);
                    break;
                case "P":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_P);
                    break;
                case "A":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_A);
                    break;
                case "S":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_S);
                    break;
                case "D":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_D);
                    break;
                case "F":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_F);
                    break;
                case "G":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_G);
                    break;
                case "H":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_H);
                    break;
                case "J":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_J);
                    break;
                case "K":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_K);
                    break;
                case "L":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_L);
                    break;
                case "Z":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_Z);
                    break;
                case "X":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_X);
                    break;
                case "C":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_C);
                    break;
                case "V":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_V);
                    break;
                case "B":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_B);
                    break;
                case "N":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_N);
                    break;
                case "M":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_M);
                    break;
                case "F1":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F1);
                    break;
                case "F2":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F2);
                    break;
                case "F3":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F3);
                    break;
                case "F4":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F4);
                    break;
                case "F5":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F5);
                    break;
                case "F6":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F6);
                    break;
                case "F7":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F7);
                    break;
                case "F8":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F8);
                    break;
                case "F9":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F9);
                    break;
                case "F10":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F10);
                    break;
                case "F11":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F11);
                    break;
                case "F12":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.F12);
                    break;
                case "1":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_1);
                    break;
                case "2":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_2);
                    break;
                case "3":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_3);
                    break;
                case "4":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_4);
                    break;
                case "5":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_5);
                    break;
                case "6":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_6);
                    break;
                case "7":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_7);
                    break;
                case "8":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_8);
                    break;
                case "9":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_9);
                    break;
                case "0":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_0);
                    break;
                case "TAB":
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.TAB);
                    break;
                default:
                    SuperSpamEngine.Enabled = false;
                    OldSuperSpamEngine.Enabled = false;
                    MessageBox.Show("Invailid game key! you can only use A to Z, 0 to 9 and F1 to F12.", "SuperSpamEngine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void superSpamScriptingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XElement element = new XElement("Items");
            foreach (var item in listBox1.Items)
            {
                element.Add(new XElement("line", item));
            }
            XDocument document = new XDocument();
            document.Add(element);
            saveFileDialog1.Title = "Save as xml";
            saveFileDialog1.Filter = "xml file (*.xml) | *.xml";
            saveFileDialog1.AddExtension = false;
            saveFileDialog1.ShowDialog();
            try { document.Save(saveFileDialog1.FileName, SaveOptions.DisableFormatting); } catch { }
        }


        private void loadArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Open a xml file";
            openFileDialog1.Filter = "xml file (*.xml) | *.xml";
            openFileDialog1.AddExtension = false;
            openFileDialog1.ShowDialog();
            XDocument xmldoc = XDocument.Load(openFileDialog1.FileName);
            var items = (from i in xmldoc.Descendants("items")
                         select new { Value = i.Element("line").Value }).ToList();

            listBox1.DataSource = items;
            listBox1.DisplayMember = "items";
            listBox1.ValueMember = "line";
        }
        private void enableDisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(enableDisableToolStripMenuItem.Checked == false)
            {
                enableDisableToolStripMenuItem.Checked = true;
            }
            else
            {
                enableDisableToolStripMenuItem.Checked = false;
            }
        }
    }
}

public static class errorhandler
{
    public static string ShowError(string exception, string custom_text = null)
    {
        if (custom_text == null)
        {
            MessageBox.Show("CRASH!\nPlease make a screenshot, and report it to marf it will help the project! \n\nException:\n" + exception, "SuperSpam CrashCatcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            MessageBox.Show("CRASH!\n" +  custom_text + " \n\nException:\n" + exception, "SuperSpam CrashCatcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        return null;
    }
}


//string promptValue = Prompt.ShowDialog("Test", "123");
public static class Prompt
{
    public static string ShowDialog(string text, string caption, string textboxdata)
    {
        if (textboxdata == null)
        { textboxdata = ""; }
        Form prompt = new Form()
        {
            Width = 500,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen,
            ControlBox = false
        };
        Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
        TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400, Text = textboxdata };
        Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
        Button Nope = new Button() { Text = "Cansel", Left = 200, Width = 50, Top = 70, DialogResult = DialogResult.Cancel};
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    }
}

class IniFile   // revision 11 http://stackoverflow.com/questions/217902/reading-writing-an-ini-file
{
    string Path;
    string EXE = Assembly.GetExecutingAssembly().GetName().Name;

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

    public IniFile(string IniPath = null)
    {
        Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
    }

    public string Read(string Key, string Section = null)
    {
        var RetVal = new StringBuilder(255);
        GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
        return RetVal.ToString();
    }

    public void Write(string Key, string Value, string Section = null)
    {
        WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
    }

    public void DeleteKey(string Key, string Section = null)
    {
        Write(Key, null, Section ?? EXE);
    }

    public void DeleteSection(string Section = null)
    {
        Write(null, null, Section ?? EXE);
    }

    public bool KeyExists(string Key, string Section = null)
    {
        return Read(Key, Section).Length > 0;
    }
}
