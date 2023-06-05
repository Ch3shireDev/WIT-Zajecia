using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadCrib
{
    delegate void AppendTextProc(string Line);
    public partial class ThreadCrib : Form
    {
        private bool cancel = false;
        public ThreadCrib()
        {
            InitializeComponent();
        }

        void AppendText(string Line)
        {
            EdLog.AppendText(Line + Environment.NewLine);
        }
        void InvokeAppendText(string Line)
        {
            Invoke(new AppendTextProc(AppendText), new object[] { Line });
        }

        private void run()
        {
            for(int i=0;i<10;++i)
            {
                if (cancel) break;
                InvokeAppendText((10 * (i + 1)).ToString()+'%');
                Thread.Sleep(500);
            }
        }

        private void run2(object x)
        {
            int xx = (int)x;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //new Thread(run).Start();
            //new Thread(run2).Start(2);
            new MyThread(1,1000000,InvokeAppendText).Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancel)
            {
                cancel = true;
                MyThread.cancel();
                e.Cancel = true;
                Invoke((MethodInvoker)delegate { Close(); });
            }
        }
    }

    class MyThread
    {
        private ulong start,count;
        private AppendTextProc proc;
        private static bool canceled = false;
        public double result { get; set; }
        public static void cancel() { canceled = true; }
        public MyThread(ulong start, ulong count, AppendTextProc proc)
        {
            this.start = start;
            this.count = count;
            this.proc = proc;
        }
        private void run()
        {
            for (ulong i = start; i < count; ++i)
            {
                if (canceled) break;
                proc((10 * (i + 1)).ToString() + '%');
                //Thread.Sleep(500);
            }
        }

        public void Start()
        {
            new Thread(run).Start();
        }
    }
}
