using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperSpam
{
    public partial class SuperSpam_Theme : Form
    {
        public SuperSpam_Theme()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                panel3.BackColor = colorDialog1.Color;
                button4.BackColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                panel4.BackColor = colorDialog1.Color;
                panel5.BackColor = colorDialog1.Color;
                button5.BackColor = colorDialog1.Color;
            }
        }

        private void SuperSpam_Theme_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                panel2.BackColor = colorDialog1.Color;
                button6.BackColor = colorDialog1.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                panel2.ForeColor = colorDialog1.Color;
                button7.BackColor = colorDialog1.Color;
            }
        }
    }
}
