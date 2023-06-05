using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Server
{
    public partial class ServerMain : Form
    {
        public ServerMain()
        {
            InitializeComponent();
            Progres1.Maximum = 5000;
            Progres2.Maximum = 5000;
            Progres3.Maximum = 5000;
        }

        public ProgressBar FindFreeBar()
        {

            foreach (Control ctrl in Controls)
            {
                if (ctrl is ProgressBar)
                {
                    ProgressBar pb = ctrl as ProgressBar;
                    if (pb.Tag == null) return pb;
                }
            }
            return null;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            Worker w = new Worker(this);
        }

        private void ServerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is ProgressBar)
                {
                    ProgressBar pb = ctrl as ProgressBar;
                    if (pb.Tag != null)
                    {
                        Worker w = pb.Tag as Worker;
                        w.Abort();
                    }
                }
            }
        }
    }

    public class Worker
    {
        protected ServerMain Frm;
        protected ProgressBar Progres;
        protected Thread Th;
        protected int sprocent;
        delegate void SetButtonEnabled(bool Value);
        delegate void SetProgressValue(int Value);

        public Worker(ServerMain Frm)
        {
            sprocent=-1;
            this.Frm = Frm;
            this.Progres = Frm.FindFreeBar();
            if (Progres != null) Progres.Tag = this;
            ThreadButtonEnabled(Frm.FindFreeBar() != null);
            Th = new Thread(new ThreadStart(work));
            Th.Priority = ThreadPriority.BelowNormal;
            Th.Start();
        }

        public void ButtonEnabled(bool Enabled)
        {
            Frm.BtnRun.Enabled = Enabled;
        }

        public void ThreadButtonEnabled(bool Enabled)
        {
            Frm.Invoke
            (
                new SetButtonEnabled(ButtonEnabled),
                new object[] { Enabled }
            );
        }

        public void ProgressValue(int Value)
        {
            Progres.Value = Value;
        }

        public void ThreadProgressValue(int Value)
        {
            int pm = Progres.Maximum;
            int nprocent = ((100 * Value + (pm>>1)) / pm);
            if (sprocent != nprocent)
            {
                sprocent = nprocent;
                Frm.Invoke
                (
                    new SetProgressValue(ProgressValue),
                    new object[] { Value }
                );
            }
        }

        protected void Finish()
        {
            ThreadProgressValue(0);
            Progres.Tag = null;
            ThreadButtonEnabled(true);
        }

        public void Abort()
        {
            Th.Abort();
            Th.Join();
        }

        public void work()
        {
            ThreadProgressValue(0);
            try
            {
                for (int i = 0; i < 5000; ++i)
                {
                    Thread.Sleep(1);
                    ThreadProgressValue(i + 1);
                }
                Finish();
            }
            catch (Exception)
            {
            }
        }
    }
}