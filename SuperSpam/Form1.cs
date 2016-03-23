/// Thanks to Sadusko for the new updater system

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


namespace SuperSpam
{

    public partial class Form1 : Form
    {
        // Version Info
        Process currentProc = Process.GetCurrentProcess();
        string versie = "2.5.0";
        int version_int = 250;

        // Build info
        int buildnum = 208;
        string buildtype = "Pre-Alpha";
        string builddate = "23-3-2016";
        string codename = "engliesh";

        //Update System
        string updateserver = "http://www.sweetnyancraft.nl/projects/Super/SuperSpam.exe";
        string server = "http://www.sweetnyancraft.nl/projects/Super/index.html";
        public string changelog = "http://www.sweetnyancraft.nl/projects/Super/changelog.html"; // niet in gebruik
        public string new_version = "";

        //Kill Switch
        string kill = "1";
        string new_date = "";

        //Debugging
        Boolean in64now = Environment.Is64BitProcess;
        Boolean Debug_mode = true;

        //See how many cpu cores there is, maybe useful for multithreading in the future
        string cpus = Environment.ProcessorCount.ToString();

        //end

        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
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
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You cant spam if you dont have anything in the textbox...", "SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            EngineChoser.Enabled = false;
            Counter.Visible = true;
            afteller.Enabled = true;
            debuglog("SuperSpam " + EngineChoser.Text  + " Begint. Wacht 5 seconden...", "Engine");
            }
        }

        private void SuperSpamEngine_Tick(object sender, EventArgs e)
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
            toolStripStatusLabel1.Text = "SuperSpam " + versie + " Build: " + buildnum + " " + buildtype;
            debuglog("SuperSpam Bootstrapper Started.", "info");
            debuglog("SuperSpam " + versie + " Build: " + buildnum + " " + buildtype, "info");
            this.Text = "SuperSpam² " + versie;
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
                    float old_v = float.Parse(versie);
                    float new_v = float.Parse(new_version);

                    /*
                    WebClient wb = new WebClient("je porn website.");
                    StreamReader sr = new StreamReader(wb);



                    debuglog("Checkt voor nieuwe versie...", "Activatie_thread");
                    //http://stackoverflow.com/questions/2471209/how-to-read-a-file-from-internet 

                    
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
                    debuglog("Versie online: " + new_version + " Deze versie: " + versie, "info");*/
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
            textBox1.Visible = false;
            menuStrip1.Visible = false;
        }

        public void start_gui()
        {
            ControlPanel.Visible = true;
            textBox1.Visible = true;
            menuStrip1.Visible = true;

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

        public void debuglog( string e, string a )
        {
            string tijd = DateTime.Now.ToString("HH:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            Debug.WriteLine("[" + tijd + "|" + a + "] " + e);
           
        }

        private void OldSuperSpamEngine_Tick(object sender, EventArgs e)
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
            //Thanks to Cp022 to Translate this part!
            MessageBox.Show("SuperSpam Version: " + versie + " Build: " + buildnum + "\n\nSuperSpam is made by Marvin Ferwerda, \nThis software is made for entertainment purposes and nothing more. \nI Marvin Ferwerda am not resposible for any results that are caused by and or via this program \nOnly use it at your own risk.", "About SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
