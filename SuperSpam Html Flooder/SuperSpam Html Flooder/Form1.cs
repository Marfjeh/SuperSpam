/*
    Dit software is gemaakt door Marvin Ferwerda.
    Ik ben niet vantwoordelijk voor schade, oorlog wat dan ook.
    Deze software kan met misbruik serieuse schade aan brengen tegen slactoffers.
    gebruik deze software alleen voor je zelf om te testen, of dat iemand anders je toetemming gegeven hebt.
    uitgezonderd: Fishings sites want die moeten gewoon plat.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSpam_Html_Flooder
{
    public partial class Form1 : Form
    {
        int aftel = 0;
        string[] randomtekst = { "Do you know what the bird is?",
            "BECAUSE EVERYONE KNOWS WHAT THE BIRD WAS BIRD BIRD BIRD",
            "DO YOU WANT BUILD A SPAMBOTTTTT???",
            "O rly?",
            "You don't Say?!",
            "Antwoordbladen bij een toets. #Fail",
            "Lets fuck up some scammers!",
            "Try my sister program, SuperSpam!",
            "When sites Fail...",
            "When Spam Fail...",
            "Scriptkiddies -.-",
            "Telefoon weg of jij weg!"};



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.AppendText("[Warning] Gebruik dit als de website snel is, anders vink je de flood op pagina geladen vinkje, en zet dit uit.");
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SPAM();
        }

        private void SPAM()
        {
            

            label7.Text = aftel.ToString();

            if (textBox9.Text == "")
            {
                timer1.Enabled = false;
                richTextBox1.AppendText(Environment.NewLine + "[LETOP] Knop ID mag niet leeg zijn. anders kan ik niks grapjas. als je niet weet hoe dit werkt, klik de ? knop. je moet wel redelijke html kennis hebben");
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
            else
            {
                try
                {
                    if (checkBox1.Checked == true)
                {
                    webBrowser1.Document.GetElementById(textBox5.Text).InvokeMember("click");
                    webBrowser1.Document.GetElementById(textBox5.Text).SetAttribute("value", textBox1.Text);
                }


                if (checkBox2.Checked == true)
                { 
                    webBrowser1.Document.GetElementById(textBox6.Text).InvokeMember("click");
                    webBrowser1.Document.GetElementById(textBox6.Text).SetAttribute("value", textBox2.Text);
                }

                if (checkBox3.Checked == true)
                {
                    webBrowser1.Document.GetElementById(textBox7.Text).InvokeMember("click");
                    webBrowser1.Document.GetElementById(textBox7.Text).SetAttribute("value", textBox3.Text);
                }


                if (checkBox4.Checked == true)
                { 
                    webBrowser1.Document.GetElementById(textBox8.Text).InvokeMember("click");
                    webBrowser1.Document.GetElementById(textBox8.Text).SetAttribute("value", textBox4.Text);
                }
              
                    webBrowser1.Document.GetElementById(textBox9.Text).InvokeMember("click");
                    aftel++;
                }
                catch(Exception e)
                {
                    //MessageBox.Show("Er is een fout opgetreden! \n\nFout:\n\n"+ e);

                    string fout = e.ToString();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(Environment.NewLine +  "[Error!] " + fout);
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();

                }
            }
        }
        private void checker()
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox5.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox5.Enabled = false;
            }


            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox6.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox6.Enabled = false;
            }

            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox7.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                textBox7.Enabled = false;
            }

            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox8.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
                textBox8.Enabled = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int interval = Convert.ToInt32(numericUpDown1.Value);
            timer1.Interval = interval;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Dit software is gemaakt door Marvin Ferwerda."
                                + "\nDit is gemaakt om te laten zien waarom je altijd een anti-spam systeem moet hebben voor je form's op je site."
                                + "\nIk ben niet vantwoordelijk voor schade, oorlog wat dan ook."
                                + "\nDeze software kan met misbruik zware schade aan brengen tegen slactoffers."
                                + "\nLet er bij op in nederland, is spammen een stafbaar feit!"
                                + "\ngebruik deze software alleen voor je zelf om te testen, of dat iemand anders je toetemming gegeven hebt."
                                + "\nuitgezonderd: Fishings sites want die moeten gewoon plat."
                                + "\n SuperSpam Html form flooder versie 0.3"
                                + "\n--------------\n";
            Random random = new Random();
            int randomNumber = random.Next(0, 11);
            this.Text = "SuperSpam Html Form Flooder //" + randomtekst[randomNumber];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPAM();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                webBrowser1.Navigate (textBox10.Text);
                SPAM();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEZE PROGRAMMA IS ALLEEN MISSCHIEN TE SNAPPEN DOOR MENSEN DIE REDELIJKE HTML KENNIS HEBBEN.\n In de ID moet de id komen van de <text> Voorbeeld:\n<input type='text' id='gebruikersnaam'/> \nDe ID is dus gebruikers naam. dat werkt ook voor de knop id alleen je moet kijken bij de <button> of <input type='button> kijken. \n\nje kan de source code zien om op de webpagina en dan broncode weergeven of element especteren.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "Typ de url in pl0x")
            {
                MessageBox.Show("heel grappig typ een url in.");

            }
            {
                webBrowser1.Navigate(textBox10.Text.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sweetnyancraft.nl/projects/Super/SuperSpam.exe");
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = "0";
            aftel = 0;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
