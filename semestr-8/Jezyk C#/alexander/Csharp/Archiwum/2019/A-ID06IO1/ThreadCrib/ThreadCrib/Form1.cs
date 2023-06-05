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
    public partial class Form1 : Form
    {
        delegate void AppendTextProc(string Line);
        private bool cancel = false;
        public Form1()
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
            int xx = (Int32)x;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            new Thread(run).Start();
            new Thread(run2).Start(2);
            new MyThread(1,1000).Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancel = true;
        }
    }

    class MyThread
    {
        private ulong start,count;
        public double result { get; set; }
        public MyThread(ulong start, ulong count)
        {
            this.start = start;
            this.count = count;
        }

        private void run()
        {
            ...
        }

        public void Start()
        {
            new Thread(run).Start();
        }
    }
}
