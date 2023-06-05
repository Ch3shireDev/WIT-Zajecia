using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Threads
{
    public partial class ThreadMain : Form
    {
        public ThreadMain()
        {
            InitializeComponent();
            foreach (Control i in Controls)
            {
                if (i is ProgressBar)
                {
                    (i as ProgressBar).Maximum = 1000;
                }
            }
        }

        public ProgressBar FindFree()
        {
            foreach (Control i in Controls)
            {
                if (i is ProgressBar)
                {
                    if (i.Tag == null) return i as ProgressBar;
                }
            }
            return null;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            int Max;
            if (Int32.TryParse(MaxCount.Text, out Max))
            {
                new Worker(this);
                MaxCount.SelectAll();
                MaxCount.Focus();
            }
        }

        private void ThreadMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Control i in Controls)
            {
                if (i is ProgressBar)
                {
                    Worker w = i.Tag as Worker;
                    if (w != null) w.Abort();
                }
            }
        }
    }

    public class Worker
    {
        private ThreadMain Frm;
        private ProgressBar Bar;
        private Thread Th;
        delegate void SetBool(bool Value);
        delegate void SetInt(int Value);

        public Worker(ThreadMain AFrm)
        {
            Frm = AFrm;
            Bar = Frm.FindFree();
            if (Bar != null)
            {
                Bar.Tag = this;
                //ThreadSetButton(Frm.FindFree()!=null);
                //SetButton(Frm.FindFree()!=null);
                Frm.Start.Enabled = (Frm.FindFree() != null);
                Th = new Thread(new ThreadStart(work));
                Th.Priority = ThreadPriority.BelowNormal;
                Th.Start();
            }
        }

        void SetButton(bool Enabled)
        {
            Frm.Start.Enabled = Enabled;
        }

        void ThreadSetButton(bool Enabled)
        {
            Frm.Invoke
            (
                new SetBool(SetButton),
                new Object[] { Enabled }
            );
        }

        void SetProgress(int Value)
        {
            Bar.Value=Value;
        }

        void ThreadSetProgress(int Value)
        {
            Frm.Invoke
            (
                new SetInt(SetProgress),
                new Object[] { Value }
            );
        }

        public void Abort()
        {
            Th.Abort();
            Th.Join();
        }

        public void work()
        {
            ThreadSetProgress(0);
            for (int i = 1; i <= 1000; ++i)
            {
                Thread.Sleep(1);
                ThreadSetProgress(i);
            }
            ThreadSetProgress(0);
            Bar.Tag = null;
            ThreadSetButton(true);
        }

    }

}