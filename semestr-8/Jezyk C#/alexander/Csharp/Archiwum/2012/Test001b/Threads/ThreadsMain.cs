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
                new Worker(this,Max);
            }
            else 
            MaxCount.SelectAll();
            MaxCount.Focus();
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
        private int Max, Prc;
        delegate void SetBool(bool Value);
        delegate void SetInt(int Value);
        delegate void SetString(string Value);

        public Worker(ThreadMain AFrm, int AMax)
        {
            Frm = AFrm;
            Max = AMax;
            Prc = -1;
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
            int p = (int)(100.0 * Value / Max); //  + 0.5
            if (Prc != p)
            {
                Prc = p;
                Frm.Invoke
                (
                    new SetInt(SetProgress),
                    new Object[] { (int)p }
                );
            }
        }

        void ShowResult(string Value)
        {
            Frm.Result.AppendText(Value);
        }

        void ThreadShowResult(string Value)
        {
            Frm.Invoke
            (
                new SetString(ShowResult),
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
            double Sum = 0;
            for (int i = 1; i <= Max; ++i)
            {
                Sum+=1.0/i;
                //Thread.Sleep(1);
                ThreadSetProgress(i);
            }
            ThreadSetProgress(0);
            ThreadSetButton(true);
            ThreadShowResult(Max.ToString() + ": " + Sum.ToString()+ '\n');
            Bar.Tag = null;
        }

    }

}