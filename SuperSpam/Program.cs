using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSpam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {
                Application.Run(new Form1());
            }
            catch (Exception e)
            {
                MessageBox.Show(":( CRASH! \n\nSuperSpam is gecrasht door een ernstige fout en kon niet meer de fout herstellen, indien u bezig was met een bestand is dat bestand verloren. Het volgende:\n indien dit de eerste keer is, probeer het zelfde te doen wat u deed toe het programma crasht, als het weer gebeurd maak er een screenshot, en stuur het naar marf op met deze infomatie hieronder kan ik het probleem vinden en oplossen. \n\n\n " + e, "SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
