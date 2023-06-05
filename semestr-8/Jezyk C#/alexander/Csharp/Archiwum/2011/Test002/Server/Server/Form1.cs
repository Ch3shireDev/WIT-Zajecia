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
    public partial class Server : Form
    {
        delegate void SetArrange(ProgressFrame pf);

        public Server()
        {
            InitializeComponent();
        }

        public void Arrange(ProgressFrame pf)
        {
            if (pf != null)
            {
                pf.Dispose();
            }
            int H=1,W=Box.ClientSize.Width-2;
            foreach (Control ctrl in Box.Controls)
            {
                if (ctrl is ProgressFrame)
                {
                    pf = ctrl as ProgressFrame;
                    pf.Bounds = new Rectangle(1, H, W, 23);
                    H += 24;
                }
            }
        }

        public void ThreadArrange(ProgressFrame pf)
        {
            Invoke
            (
                new SetArrange(Arrange),
                new object[] { pf }
            );
        }

        private void Server_Resize(object sender, EventArgs e)
        {
            Box.AutoScrollMinSize = new Size(0,Box.Height + 1);
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            uint max;
            UInt32.TryParse(Emax.Text, out max);
            Worker w = new Worker(this,max);
        }

        private void Emax_TextChanged(object sender, EventArgs e)
        {
            uint max;
            BtnRun.Enabled=UInt32.TryParse(Emax.Text,out max);
        }

        public void pb_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Arrange(btn.Parent as ProgressFrame);
        }
    }

    public class Worker
    {
        protected Server Frm;
        protected ProgressBar Progres;
        protected ProgressFrame Frame;
        protected Thread Th;
        protected int sprocent;
        delegate void SetProgressValue(int Value);

        public Worker(Server Frm,uint max)
        {
            sprocent = -1;
            this.Frm = Frm;
            Frame =new ProgressFrame();
            Progres = Frame.Bar;
            Frame.BtnCancel.Click += Frm.pb_Click;
            Progres.Maximum = (int)max;
            Frame.Parent = Frm.Box;
            Frm.Arrange(null);
            Th = new Thread(new ThreadStart(work));
            Th.Priority = ThreadPriority.BelowNormal;
            Th.Start();
        }

        public void ProgressValue(int Value)
        {
            Progres.Value = Value;
            Frm.Text = Progres.Value.ToString() + "/" + Progres.Maximum.ToString();
        }

        public void ThreadProgressValue(int Value)
        {
            int pm = Progres.Maximum;
            int nprocent = ((100 * Value /* + (pm >> 1) */ ) / pm);
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
            Progres.Tag = null;
            Frm.ThreadArrange(Frame);
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
                for (int i = 0; i < Progres.Maximum; ++i)
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