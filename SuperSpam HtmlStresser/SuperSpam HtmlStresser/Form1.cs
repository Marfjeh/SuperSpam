using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSpam_HtmlStresser
{
    public partial class Form1 : Form
    {
        public string url = "about:blank";
        public int interval = 100;
        public Boolean timer = false;
        public int hits = 0;
        public int vensters = 0;
        public Boolean laadpasnageladen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = interval;
            MessageBox.Show("WAARSCHUWING! \n Deze programa is bedoeld om te testen hoe je eigen website doet met veel bekijkers per seconden. GEBRUIK DIT ALLEEN OP JE EIGEN WEBSITES \nHet kan ZWARE SCHADE BRENGEN. Dit is een Soort DOS Attack. en is ILIGAAL in Nederland en andere landen om het bij anderen te doen. nogmaals, DEZE PROGRAMMA IS ALLEEN OM JE EIGEN WEBSITE TE TESTEN\nGEBRUIK OP EIGEN RISICO", "WAARSHCUWING");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            websimu newMDIChild = new websimu();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            vensters++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            url = textBox1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var web = Application.OpenForms["websimu"] as websimu;
            timer = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Total Bots: " + vensters;
            toolStripStatusLabel2.Text = "Hits: " + hits;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            interval = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form[] childArray = this.MdiChildren;
            foreach (Form childform in childArray)
            {
                childform.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                laadpasnageladen = true;
                
            }
            else
            {
                laadpasnageladen = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
