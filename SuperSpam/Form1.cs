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
        string versie = "2.4.0"; // Versie
        int buildnum = 142; // Build nummer
        string buildtype = "Alpha"; // type van versie, begint met beta als het af is Release.
        string builddate = "14-12-2015"; // de build date van deze versie
        string codename = "HappyBOOM";
        string updateserver = "http://www.sweetnyancraft.nl/projects/Super/SuperSpam.exe"; // de update path
        string server = "http://www.sweetnyancraft.nl/projects/Super/index.html"; //De server waar de infomatie word gedownload
        public string changelog = "http://www.sweetnyancraft.nl/projects/Super/changelog.html"; // niet in gebruik
        public string new_version = ""; // De nieuwe versie die nu op het net staat.
        string kill = "1"; //Globale Killswitch, zonder internet werkt de programma niet. default op 1, maar veranderd na verbinden met de server.
        string killversion = "2.1"; // versie killswitch, dat het verouderd is en niet meer te gebruiken is
        string new_date = ""; // De datum van de nieuwe versie, word pas beschrikbaar na het verbinden van de server.
        Boolean in64now = Environment.Is64BitProcess; // kijkt dat superspam in een 64 bit process draait.
        Boolean Debug_mode = true; // debug modus zet de mogelijkheid om de killswitch om te omzeilen, en schakeld debug knoppen in, en geeft meer infomatie in de titelbalk. hey scriptkiddie, schakel dit in om het te omzeilen. wat makkelijk he? 1337 h4x0r, HEKKIE.
        Boolean Consolev = true;
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
            int interval = Convert.ToInt32(numericUpDown1.Value);
            debuglog("Engine snelheid: " + interval.ToString(), "info");
            SuperSpamEngine.Interval = interval;
            OldSuperSpamEngine.Interval = interval;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            label6.Visible = true;
            afteller.Enabled = true;
            debuglog("SuperSpam " + comboBox1.Text  + " Begint. Wacht 5 seconden...", "Melding");
        }

        private void SuperSpamEngine_Tick(object sender, EventArgs e)
        {

            
           // if (checkBox1.Checked == true)
            //{
                InputSimulator.SimulateTextEntry(textBox1.Text);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
            //}
            //else
            //{
              //  InputSimulator.SimulateTextEntry(textBox1.Text);
            //}
            }

        private void button4_Click(object sender, EventArgs e)
        {
            debuglog("SuperSpam " + comboBox1.Text + " Gestopt.", "Melding");
            comboBox1.Enabled = true;
            SuperSpamEngine.Enabled = false;
            OldSuperSpamEngine.Enabled = false;
            afteller.Enabled = false;
            label6.Text = "5";
            label6.Visible = false;
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
            this.Text = "SuperSpam " + versie;
            label3.Text = "Made by: Marf Ver: " + versie;
            stop_gui();
            int interval = Convert.ToInt32(numericUpDown1.Value);
            SuperSpamEngine.Interval = interval;
            webBrowser1.Navigate(server);
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
                        if (Debug_mode == true)
                        {
                            label3.Text = "Versie: " + versie + " Build: " + buildnum + "\n HAI MARF :DDDD";
                            debuglog("Hoi marf :)", "Activatie_thread");
                        }
                        else
                        {
                            stop_gui();
                            MessageBox.Show("Activatie server meld het volgende: \nDeze versie is ongeldig. het programma sluit nu.", "Activatie Server", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            debuglog("Ongeldige versie gevonden.", "Activatie_thread");
                            this.Close();

                        }


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
            panel1.Visible = false;
            textBox1.Visible = false;
        }

        public void start_gui()
        {
            panel1.Visible = true;
            textBox1.Visible = true;

        }
        private void afteller_Tick(object sender, EventArgs e)
        {
            int aftel = Convert.ToInt32(label6.Text);
            
            if (aftel == 0)
            {
                afteller.Enabled = false;
                label6.Text = "5";
                if (comboBox1.Text == "Engine 1")
                {
                    SuperSpamEngine.Enabled = true;
                }
                else
                {
                    OldSuperSpamEngine.Enabled = true;
                }
                label6.Visible = false;
            }
            else
            {
                aftel = aftel - 1;
                label6.Text = Convert.ToString(aftel);
                
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
            if (panel1.Visible == true)
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
            textBox1.Text = "";
        }

        private void debuggerToolStripMenuItem_Click(object sender, EventArgs e)
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
                + "\nSpamEngine in gebruik: " + comboBox1.Text
                + "\nSpamEngine Status: " + SuperSpamEngine.Enabled.ToString()
                + "\nSpamEngine Snelheid: " + SuperSpamEngine.Interval.ToString()
                + "\nPath: " + SpamPath
                + "\nHoeveel gebruikt superspam: " + memoryUsed / naarmb + " MB");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void nieuweVersieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 UpdateForm = new Form2();
            UpdateForm.Show();
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
    }
}
