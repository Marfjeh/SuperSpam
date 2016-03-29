﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SuperSpam
{
    static class Program
    {
        // Add "global\" in front of the EventName, then only one instance is allowed on the
        // whole system, including other users. But the application can not be brought
        // into view, of course. 
        private static String SingleAppComEventName = "37b5e650-2b1a-4b40-9029-fb025c4ec141";
        private static BackgroundWorker singleAppComThread = null;
        private static EventWaitHandle threadComEvent = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // another instance is already running if OpenExsting succeeds.
                threadComEvent = EventWaitHandle.OpenExisting(SingleAppComEventName);
                threadComEvent.Set();  // signal the other instance.
                threadComEvent.Close();
                return;    // return immediatly.
            }
            catch
            {
              }
            // Create the Event handle
            threadComEvent = new EventWaitHandle(false, EventResetMode.AutoReset, SingleAppComEventName);
            CreateInterAppComThread();
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception e)
            {
                MessageBox.Show("CRASH! \n\nException:\n" + e, "SuperSpam", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            // End the communication thread.
            singleAppComThread.CancelAsync();
            while (singleAppComThread.IsBusy)
                Thread.Sleep(50);
            threadComEvent.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        static private void CreateInterAppComThread()
        {
            singleAppComThread = new BackgroundWorker();
            singleAppComThread.WorkerReportsProgress = false;
            singleAppComThread.WorkerSupportsCancellation = true;
            singleAppComThread.DoWork += new DoWorkEventHandler(singleAppComThread_DoWork);
            singleAppComThread.RunWorkerAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static private void singleAppComThread_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            WaitHandle[] waitHandles = new WaitHandle[] { threadComEvent };

            while (!worker.CancellationPending)
            {
                // check every second for a signal.
                if (WaitHandle.WaitAny(waitHandles, 1000) == 0)
                {
                    // The user tried to start another instance. We can't allow that, 
                    // so bring the other instance back into view and enable that one. 
                    // That form is created in another thread, so we need some thread sync magic.
                    if (Application.OpenForms.Count > 0)
                    {
                        Form mainForm = Application.OpenForms[0];
                        mainForm.Invoke(new SetFormVisableDelegate(ThreadFormVisable), mainForm);
                    }
                }
            }
        }
        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// When this method is called using a Invoke then this runs in the thread
        /// that created the form, which is nice. 
        /// </summary>
        /// <param name="frm"></param>
        private delegate void SetFormVisableDelegate(Form frm);
        static private void ThreadFormVisable(Form frm)
        {
            if (frm != null)
            {
                // display the form and bring to foreground.
                frm.Visible = true;
                frm.WindowState = FormWindowState.Normal;
                frm.Show();
                SetForegroundWindow(frm.Handle);
            }
        }
    }
}