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
    public partial class websimu : Form
    {
        public websimu()
        {
            InitializeComponent();
        }

        private void websimu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var hoofdform = Application.OpenForms["form1"] as Form1;
            if (hoofdform.timer == true)
            {
                timer1.Interval = hoofdform.interval;
                hoofdform.hits  ++;
                webBrowser1.Navigate(hoofdform.url);
            }
            else
            {

            }
        }

        private void websimu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var hoofdform = Application.OpenForms["form1"] as Form1;
            hoofdform.vensters --;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var hoofdform = Application.OpenForms["form1"] as Form1;
            if (hoofdform.laadpasnageladen == true)
            {
                hoofdform.hits++;
                webBrowser1.Navigate(hoofdform.url);
                System.Threading.Thread.Sleep(50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hoofdform = Application.OpenForms["form1"] as Form1;
            webBrowser1.Navigate(hoofdform.url);

        }
    }
}
