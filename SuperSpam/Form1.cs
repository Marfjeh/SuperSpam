// Dit software is gemaakt door Marvin Ferwerda Deze software is bedoeld voor entertement. gebruik is op eigen risico ik ben NIET vantwoordelijk.

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
using AeroGlass;

namespace SuperSpam
{

    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll",
           EntryPoint = "GetStdHandle",
           SetLastError = true,
           CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetStdHandle(int nStdHandle);
        [DllImport("kernel32.dll",
            EntryPoint = "AllocConsole",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        private const int STD_OUTPUT_HANDLE = -11;
        private const int MY_CODE_PAGE = 437;

        Process currentProc = Process.GetCurrentProcess();
        string versie = "3.0.0"; // Versie
        int buildnum = 172; // Build nummer
        string buildtype = "Pre-Alpha"; // type van versie, begint met beta als het af is Release.
        string builddate = "4-1-2016"; // de build date van deze versie
        string codename = "tribus";
        string updateserver = "http://www.sweetnyancraft.nl/projects/Super/SuperSpam.exe"; // de update path
        string server = "http://www.sweetnyancraft.nl/projects/Super/index.html"; //De server waar de infomatie word gedownload
        public string changelog = "http://www.sweetnyancraft.nl/projects/Super/changelog.html"; // niet in gebruik
        public string new_version = ""; // De nieuwe versie die nu op het net staat.
        string kill = "1"; //Globale Killswitch, zonder internet werkt de programma niet. default op 1, maar veranderd na verbinden met de server.
        string new_date = ""; // De datum van de nieuwe versie, word pas beschrikbaar na het verbinden van de server.
        Boolean in64now = Environment.Is64BitProcess; // kijkt dat superspam in een 64 bit process draait.
        Boolean Debug_mode = true; // debug modus zet de mogelijkheid om de killswitch om te omzeilen, en schakeld debug knoppen in, en geeft meer infomatie in de titelbalk. hey scriptkiddie, schakel dit in om het te omzeilen. wat makkelijk he? 1337 h4x0r, HEKKIE.
        Boolean Consolev = false; // opend een console venster waar de debug info word geprint.
        int gcaan = 1;
        //System info
        string OS = Environment.OSVersion.ToString(); //Welk NT versie van windows draait er?
        string Isx64 = Environment.Is64BitOperatingSystem.ToString(); // is de bestruringsysteem 64 bit?
        string cpus = Environment.ProcessorCount.ToString(); // Hoeveel Cpus/Cores/Threats bij elkaar zijn er?
        string pcnaam = Environment.MachineName.ToString(); // DE NETBIOS naam van de computer
        string SpamPath = Environment.CurrentDirectory.ToString(); // waar Superspam draait is misschien nodig voor de toekomst.
        //string Argument = Environment.GetCommandLineArgs.ToString(); // krijg arguments hoe het progamma start, voor de toekomst

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
        }

        public void setcolors(Color balkmenu, Color balkcontrols, Color tekstbox, Color fontcolor)
        {
            menuStrip1.BackColor = balkmenu;
            statusStrip1.BackColor = balkmenu;
            ControlPanel.BackColor = balkcontrols;
            textBox1.BackColor = tekstbox;
            ThemePanel.BackColor = balkcontrols;

            this.ForeColor = fontcolor;
            ThemePanel.ForeColor = fontcolor;
            menuStrip1.ForeColor = fontcolor;
            ControlPanel.ForeColor = fontcolor;
            textBox1.ForeColor = fontcolor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Je kan niet spammen als je niks in je tekst heb staan...", "SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            debuglog("SuperSpam Bootstrapper Started.", "info");
            debuglog("SuperSpam " + versie + " Build: " + buildnum + " " + buildtype, "info");
            if (Consolev == true)
            {
                AllocConsole();
                Console.WriteLine("***************************************");
                Console.WriteLine("* SuperSpam Chat Flooder");
                Console.WriteLine("* Version: " + versie + "\n* Build: " + buildnum + "\n* Build Date: " + builddate + " \n * Build type: " + buildtype);
                Console.WriteLine("***************************************");
                Console.WriteLine("* Debug Console");
                Console.WriteLine("***************************************");
            }
            notifyIcon2.Text = "SuperSpam Versie: " + versie + " Build: " + buildnum + " " + buildtype;
            //Message_Window.Dock = DockStyle.Fill;
            this.Text = "SuperSpam Pre-Alpha Codename: tribus";
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
                        MessageBox.Show("De kill switch is geactiveerd. dat wil zeggen dat deze versie te verouderd is of uitgeschakeld is voor andere redenen. vraag aan marf", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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
                    debuglog("Checkt voor nieuwe versie...", "Activatie_thread");
                    if (old_v == new_v)
                    {
                        // Geen nieuwe Versie gevonden!
                        debuglog("Er is geen nieuwe versie gevonden. Versie online: " + new_version + " Deze versie: " + versie, "info");
                    }
                    else if (old_v >= new_v)
                    {
                        //if (Debug_mode == true)
                       // {
                            VersionInfoLabel.Text = "Versie: " + versie + " Build: " + buildnum + "\n HAI MARF :DDDD";
                            debuglog("Hoi marf :)", "Activatie_thread");
                        //}
                       /* else
                        {
                            stop_gui();
                            MessageBox.Show("Activatie server meld het volgende: \nDeze versie is ongeldig. het programma sluit nu.", "Activatie Server", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            debuglog("Ongeldige versie gevonden.", "Activatie_thread");
                            this.Close();

                        }*/


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
                    MessageBox.Show("Er is een fout opgetreden bij het ophalen van de infomatie van de server, het programma sluit nu", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    debuglog("Kon niet verbinden met server \n" + b, "ERROR");
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

            System.Diagnostics.Process.Start(updateserver); // maak gebruik van de systeem default browser
            //webBrowser1.Navigate(updateserver);
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
            if (gcaan == 1)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                long memory = GC.GetTotalMemory(true);
                webBrowser1.Dispose();
                debuglog("GC uitgevoerd.", "Info");
            }
            else
            {
                debuglog("GC aanvraag ingedient, maar niet uitgevoerd omdat het uit staat.", "Error");
            }

        }

        public void debuglog( string e, string a )
        {
            string tijd = DateTime.Now.ToString("HH:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            Debug.WriteLine("[" + tijd + "|" + a + "] " + e);
            if (Consolev == true)
            {
                AllocConsole();
                Console.WriteLine("[" + tijd + "|" + a + "] " + e);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            start_gui();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            start_gui();
        }
        private void Error_Confirm_Click(object sender, EventArgs e)
        {
            start_gui();
        }

        private void trololol_Tick(object sender, EventArgs e)
        {
            if (ControlPanel.Visible == true)
            {
                stop_gui();
            }
            else
            {
                start_gui();
            }
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
                    MessageBox.Show("Fout bij het typen van het bericht, tekens ( ) zijn niet toegestaan. om dit probleem op te lossen is om Engine 1 tegebruiken");
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
                    MessageBox.Show("Fout bij het typen van het bericht, tekens ( ) zijn niet toegestaan. om dit probleem op te lossen is om Engine 1 tegebruiken");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left)
    {
        this.Location = new Point(Cursor.Position.X + e.X , Cursor.Position.Y + e.Y);
    }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void Menupanel_MouseLeave(object sender, EventArgs e)
        {
        }
        private void onlineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tekstOpenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open een txt bestand";
            openFileDialog1.Filter = "Txt bestand (*.txt) | *.txt";
            openFileDialog1.AddExtension = false;
            openFileDialog1.ShowDialog();
            try { textBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText); } catch { }
            ram_clean();
        }

        private void tekstOpslaanAlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Opslaan als txt";
            saveFileDialog1.Filter = "Txt bestand (*.txt) | *.txt";
            saveFileDialog1.AddExtension = false;
            saveFileDialog1.ShowDialog();
            try { textBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText); }
            catch { }
            ram_clean();
        }

        private void superSpamHtmlFlooderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SuperSpam_Html_Flooder.Form1 aa = new SuperSpam_Html_Flooder.Form1();
                aa.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Fout bij het opstarten van SuperSpam html flooder. is de .exe wel in de map? \n\n " + error);
            }
        }

        private void overSuperSpamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SuperSpam Versie: " + versie
                + "\n\nSuperSpam is gemaakt door Marvin Ferwerda, \nDeze software is bedoeld voor entertainment alleen. \nIk ben niet vantwoordelijk voor bans, wat dan ook. \ngebruik deze software op EIGEN RISICO."
                + "\nSuperSpam Html flooder is nu een onderdeel van het superspam project. Marf legt het uit hoe het werkt", "Over SuperSpam");
        }

        private void nieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u het zeker? je kan niks meer terug halen dat is een helelange tijd!", "SuperSpam", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
            if (Consolev == false)
            {
                long memoryUsed = currentProc.PrivateMemorySize64;
                long naarmb = 1024 * 1024;
                MessageBox.Show("------------------DEBUG------------------\n"
                    + "\nBuild in: C#"
                    + "\nBuild: " + buildnum
                    + "\nbuild type: " + buildtype
                    + "\nbuild datum: " + builddate
                    + "\nOS: " + OS
                    + "\nIs 64bit? " + Isx64
                    + "\ndraait superspam in 64bit? " + in64now
                    + "\nCpu count: " + cpus
                    + "\nDebug mode: " + Debug_mode
                    + "\nSpamEngine in gebruik: " + EngineChoser.Text
                    + "\nSpamEngine Status: " + SuperSpamEngine.Enabled.ToString()
                    + "\nSpamEngine Snelheid: " + SuperSpamEngine.Interval.ToString()
                    + "\nPath: " + SpamPath
                    + "\nHoeveel gebruikt superspam: " + memoryUsed / naarmb + " MB. Bytes: " + memoryUsed, "Debug");
            }
            else
            {
                long memoryUsed = currentProc.PrivateMemorySize64;
                long naarmb = 1024 * 1024;
                debuglog("------------------DEBUG------------------\n"
                    + "\nBuild in: C#"
                    + "\nBuild: " + buildnum
                    + "\nbuild type: " + buildtype
                    + "\nbuild datum: " + builddate
                    + "\nOS: " + OS
                    + "\nIs 64bit? " + Isx64
                    + "\ndraait superspam in 64bit? " + in64now
                    + "\nCpu count: " + cpus
                    + "\nDebug mode: " + Debug_mode
                    + "\nSpamEngine in gebruik: " + EngineChoser.Text
                    + "\nSpamEngine Status: " + SuperSpamEngine.Enabled.ToString()
                    + "\nSpamEngine Snelheid: " + SuperSpamEngine.Interval.ToString()
                    + "\nPath: " + SpamPath
                    + "\nHoeveel gebruikt superspam: " + memoryUsed / naarmb + " MB. Bytes: " + memoryUsed, "Debug");
            }
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

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
        public void consolewindow()
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int p = 1; p <= textBox1.Lines.Length; p++)
            {
                listBox1.Items.Add(p);
            }
            listBox1.SelectedItems.Add(textBox1.GetLineFromCharIndex(textBox1.SelectionStart) + 1);

            // Syntax Highlighter for Superspam
            int i = textBox1.SelectionStart;
            toolStripStatusLabel2.Text = "" + textBox1.GetLineFromCharIndex(i + 1);
            if (EngineChoser.Text == "Engine 2 (sloom)")
            {
                this.CheckKeyword("{F1}", Color.BlueViolet, 0);
                this.CheckKeyword("{F2}", Color.BlueViolet, 0);
                this.CheckKeyword("{F3}", Color.BlueViolet, 0);
                this.CheckKeyword("{F4}", Color.BlueViolet, 0);
                this.CheckKeyword("{F5}", Color.BlueViolet, 0);
                this.CheckKeyword("{F6}", Color.BlueViolet, 0);
                this.CheckKeyword("{F7}", Color.BlueViolet, 0);
                this.CheckKeyword("{F8}", Color.BlueViolet, 0);
                this.CheckKeyword("{F9}", Color.BlueViolet, 0);
                this.CheckKeyword("{F10}", Color.BlueViolet, 0);
                this.CheckKeyword("{F11}", Color.BlueViolet, 0);
                this.CheckKeyword("{F12}", Color.BlueViolet, 0);
                this.CheckKeyword("+", Color.MediumVioletRed, 0);
                this.CheckKeyword("^", Color.MediumVioletRed, 0);
                this.CheckKeyword("&", Color.MediumVioletRed, 0);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void superSpamWebViewSimulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("stress.exe");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = textBox1.SelectionStart;
            toolStripStatusLabel2.Text = "" + textBox1.GetLineFromCharIndex(i + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setcolors(Color.DarkGray, Color.Gray, Color.Black, Color.Lime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setcolors(Control.DefaultBackColor, Control.DefaultBackColor, Color.White, Control.DefaultForeColor);
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setcolors(Color.FromArgb(255, 62, 62, 62), Color.FromArgb(255, 45, 45, 48), Color.FromArgb(255, 20, 20, 20), Color.FromArgb(255, 255, 255, 255));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ThemePanel.Hide();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                gcaan = 1;
            }
            else
            {
                gcaan = 0;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Consolev = true;
                AllocConsole();
                Console.WriteLine("***************************************");
                Console.WriteLine("* SuperSpam Chat Flooder");
                Console.WriteLine("* Version: " + versie + "\n* Build: " + buildnum + "\n* Build Date: " + builddate + " \n * Build type: " + buildtype);
                Console.WriteLine("***************************************");
                Console.WriteLine("* Debug Console");
                Console.WriteLine("***************************************");
            }
            else
            {
                Consolev = false;
            }
        }

        private void secretStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemePanel.Visible = true;
        }

        private void textBox1_SelectionChanged(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Add(textBox1.GetLineFromCharIndex(textBox1.SelectionStart) + 1);
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
