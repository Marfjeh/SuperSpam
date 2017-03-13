using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HenoohDeviceEmulator;

namespace SuperSpam_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                Array_settings.Visible = true;
            }
            else
            {
                Array_settings.Visible = false;
            }
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileToolStripMenuItem.Visible == true)
            {
                fileToolStripMenuItem.Visible = false;
                settingsToolStripMenuItem1.Visible = false;
                helpToolStripMenuItem.Visible = false;
            }
            else
            {
                fileToolStripMenuItem.Visible = true;
                settingsToolStripMenuItem1.Visible = true;
                helpToolStripMenuItem.Visible = true;
            }
        }

        private void Engine3_Tick(object sender, EventArgs e)
        {
            KeyboardController kb = new KeyboardController();

            kb.TypeString(textBox1.Text);
            kb.Enter();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Engine3.Interval = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engine3.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Engine3.Enabled = false;
        }
    }
}
