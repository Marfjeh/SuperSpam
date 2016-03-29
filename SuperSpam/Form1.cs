// Thanks to Sadusko for the new updater system

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


namespace SuperSpam
{

    public partial class Form1 : Form
    {

        // Version Info
        Process currentProc = Process.GetCurrentProcess();
        string versie = "2.5.0";
        int version_int = 250;

        // Build info
        int buildnum = 216;
        string buildtype = "Pre-Release";
        string builddate = "29-3-2016";
        string codename = "Revolution";

        //Update System
        string updateserver = "http://www.sweetnyancraft.nl/projects/Super/SuperSpam.exe";
        string server = "http://www.sweetnyancraft.nl/projects/Super/index.html";
        public string changelog = "http://www.sweetnyancraft.nl/projects/Super/changelog.html"; // niet in gebruik
        public string new_version = "";
        public string new_build = "";
        public string new_version_int = "";

        //Kill Switch
        string kill = "1";
        string new_date = "";

        //Debugging
        Boolean in64now = Environment.Is64BitProcess;
        Boolean Debug_mode = false;

        //See how many cpu cores there is, maybe useful for multithreading in the future
        string cpus = Environment.ProcessorCount.ToString();
        public int tabcontrolgeselecteerd = 0;

        public object ConfigurationManager { get; private set; }

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
                    alertTimer.Enabled = true;
                    toolStripStatusLabel1.Text = "Speed below 100ms can make your system unstable!";
                }
                else
                {
                    alertTimer.Enabled = false;
                    toolStripStatusLabel1.Text = "SuperSpam " + versie + " Build: " + buildnum + " " + buildtype;
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
            label3.Text = "SuperSpam Version: " + versie + " Build: " + buildnum;
            toolStripStatusLabel1.Text = "SuperSpam " + versie + " Build: " + buildnum + " " + buildtype;
            debuglog("SuperSpam Bootstrapper Started.", "info");
            debuglog("SuperSpam " + versie + " Build: " + buildnum + " " + buildtype, "info");
            this.Text = "SuperSpam " + versie;
            VersionInfoLabel.Text = "Made by: Marf Ver: " + versie;
            stop_gui();
            int interval = Convert.ToInt32(SpeedControl.Value);
            SuperSpamEngine.Interval = interval;
            if (Debug_mode == false)
            {
                webBrowser1.Navigate(server);
            }
            else
            {
                this.Text = "SuperSpam 2 ver: " + versie + " Build: " + buildnum + " " + buildtype + " " + builddate + " DEBUG MODE";
                start_gui();
                debuglog("Superspam draait in debug mode", "WARNING");
            }
            debuglog("Begint met verbinden van de server...", "Activatie_thread");

        }

        public void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (Debug_mode == false)
            {
                try
                {

                    new_version = webBrowser1.Document.GetElementById("new_version").OuterText;
                    kill = webBrowser1.Document.GetElementById("Kill_Switch").OuterText;
                    new_date = webBrowser1.Document.GetElementById("date").OuterText;
                    new_build = webBrowser1.Document.GetElementById("beta_build").OuterText;
                    new_version_int = webBrowser1.Document.GetElementById("new_version_int").OuterText;

                    int killer = Convert.ToInt32(kill);
                    debuglog("Loaded.", "Activatie_thread");

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

                   
                    debuglog("Checkt voor nieuwe versie...", "Activatie_thread");
                    
                    if (old_v == new_v)
                    {
                        // Geen nieuwe Versie gevonden!
                        debuglog("Er is geen nieuwe versie gevonden. Versie online: " + new_version + " Deze versie: " + versie, "info");
                    }
                    else if (old_v >= new_v)
                    {
                            VersionInfoLabel.Text = "Versie: " + versie + " Build: " + buildnum + "\n HAI MARF :DDDD";
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
                }
                catch (Exception b)
                {
                    debuglog("Kon niet verbinden met server \n" + b, "ERROR");
                    MessageBox.Show("There's problem when connecting to the server. SuperSpam will close now.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
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

        private void Update_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(updateserver);
            this.Close();
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
            webBrowser1.Dispose();
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
            tabControl1.SelectTab(3);
            //Thanks to Cp022 to Translate this part!
            //MessageBox.Show("SuperSpam Version: " + versie + " Build: " + buildnum + "\n\nSuperSpam is made by Marvin Ferwerda, \nThis software is made for entertainment purposes and nothing more. \nI Marvin Ferwerda am not resposible for any results that are caused by and or via this program \nOnly use it at your own risk.\n\n\n\n Thanks to:\nSadusko, for the better updater system.\nCp_022 for translating some of the text \nMegaXLR For ideas/suggestions in the github page.", "About SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "SuperSpam", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                textBox1.Text = "";
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
            //Form2 UpdateForm = new Form2();
            //UpdateForm.Show();
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

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.textBox1.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.textBox1.SelectionStart;

                while ((index = this.textBox1.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.textBox1.Select((index + startIndex), word.Length);
                    this.textBox1.SelectionColor = color;
                    this.textBox1.Select(selectStart, 0);
                    this.textBox1.SelectionColor = Color.Black;
                }
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
            alertTimer.Enabled = false;
            toolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel1.Text = "SuperSpam " + versie + " Build: " + buildnum + " " + buildtype;
            button1.Visible = false;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
            listBox1.Items.Add(promptValue);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.last_tab = tabcontrolgeselecteerd;
            SuperSpamEngine.Enabled = false;
            OldSuperSpamEngine.Enabled = false;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        tabcontrolgeselecteerd = 0;
                        nieuwToolStripMenuItem.Enabled = true;
                        tekstOpslaanAlsToolStripMenuItem.Enabled = true;
                        tekstOpenenToolStripMenuItem.Enabled = true;
                        readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Visible = false;
                        readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Text = "none";
                        enablecontrolp(1);
                    }
                    break;
                case 1:
                    {
                        tabcontrolgeselecteerd = 1;
                        nieuwToolStripMenuItem.Enabled = false;
                        tekstOpslaanAlsToolStripMenuItem.Enabled = false;
                        tekstOpenenToolStripMenuItem.Enabled = false;
                        readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Visible = true;
                        readAndWirteToFilesInArrayModeIsAtThisMomentNotImpenentedToolStripMenuItem.Text = "Read and Write files in ArrayMode is at this moment not impented.";
                        enablecontrolp(1);
                    }
                    break;
                case 2:
                    {
                        tabcontrolgeselecteerd = 2;
                        enablecontrolp(0);
                    }
                    break;
                case 3:
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

        private void comicSansModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Comic Sans MS", 12, FontStyle.Regular);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Properties.Settings.Default.Save();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Marfjeh");
        }
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
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    }
}
