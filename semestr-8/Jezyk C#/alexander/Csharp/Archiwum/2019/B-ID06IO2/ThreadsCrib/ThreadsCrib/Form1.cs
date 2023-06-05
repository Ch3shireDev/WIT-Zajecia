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

namespace ThreadsCrib
{
    public delegate void AppendTextProc(string Text);
    public partial class Form1 : Form
    {
        private bool close = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void AppendText(string Text)
        {
            EdLog.AppendText(Text + Environment.NewLine);
        }

        private void InvokeAppendText(string Text)
        {
            if (close) return;
            Invoke(new AppendTextProc(AppendText), new Object[] { Text });
        }

        private void BtnWorker_Click(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 10; ++i)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                System.Threading.Thread.Sleep(500);
                InvokeAppendText((10*(i+1)).ToString() + '%');
                //bw.ReportProgress(10 * i);
            }

        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            InvokeAppendText(e.ProgressPercentage.ToString()+'%');
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
            bw.CancelAsync();
        }

        private void run()
        {
            for (int i = 0; i < 10; ++i)
            {
                if (close) return;
                System.Threading.Thread.Sleep(500);
                InvokeAppendText((10 * (i + 1)).ToString() + '%');
                //bw.ReportProgress(10 * i);
            }
        }

        private void Thread_Click(object sender, EventArgs e)
        {
            new Thread(run).Start();
            new MyThread(10, 32.5).Start();
        }
    }


    class MyThread
    {
        private int x;
        private double y;
        public MyThread(int x,double y)
        {
            this.x = x;
            this.y = y;
        }
        private void run()
        {

        }
        public void Start()
        {
            new Thread(run).Start();
        }
    }
}
