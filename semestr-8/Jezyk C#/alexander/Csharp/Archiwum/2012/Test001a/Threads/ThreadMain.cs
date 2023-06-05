using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Threads
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            foreach (Control cnt in Controls)
            {
                if (cnt is ProgressBar)
                {
                    ProgressBar pb = cnt as ProgressBar;
                    pb.Maximum = 10000;
                }
            }
            //System.Globalization.NumberFormatInfo.NumberDecimalSeparator = ".,";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            uint Max;
            if (UInt32.TryParse(Steps.Text,out Max))
            {
                new ThreadWork(this,Max);
            }
            Steps.SelectAll();
            Steps.Focus();
        }

        public ProgressBar FindFreeBar()
        {
            foreach (Control cnt in Controls)
            {
                if (cnt is ProgressBar)
                {
                    ProgressBar pb = cnt as ProgressBar;
                    if (pb.Tag == null) return pb;
                }
            }
            return null;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Control cnt in Controls)
            {
                if (cnt is ProgressBar)
                {
                    ProgressBar pb = cnt as ProgressBar;
                    if (pb.Tag != null)
                    {
                        ThreadWork w = pb.Tag as ThreadWork;
                        w.Abort();
                    }
                }
            }
        }

    }

    public class ThreadWork
    {
        protected Main Forma;
        protected ProgressBar Bar;
        protected Thread Th;
        public delegate void SetProgressValue(uint Value);
        public delegate void SetBooleanValue(bool Value);
        public delegate void SetTextValue(string Value);

        public ThreadWork(Main Forma, uint Max)
        {
            this.Forma = Forma;
            Bar = Forma.FindFreeBar();
            if (Bar != null)
            {
                Bar.Tag = this;
                Bar.Maximum = (int)Max;
                Forma.BtnStart.Enabled = (Forma.FindFreeBar() != null);
                //Th = new Thread(new ThreadStart(Work));
                Th = new Thread(Work);
                Th.Priority = ThreadPriority.BelowNormal;
                Th.Start();
            }
        }

        public void SetValue(uint Value)
        {
            Bar.Value = (int)Value;
        }

        public void ThreadSetValue(uint Value)
        {
            Forma.Invoke
            (
                new SetProgressValue(SetValue),
                new object[] { Value }
            );
        }

        public void SetButton(bool Enabled)
        {
            Forma.BtnStart.Enabled = Enabled;
        }

        public void ThreadSetButton(bool Enabled)
        {
            Forma.Invoke
            (
                new SetBooleanValue(SetButton),
                new object[] { Enabled }
            );
        }

        public void SetText(string Text)
        {
            Forma.Result.AppendText(Text);
        }

        public void ThreadSetText(string Text)
        {
            Forma.Invoke
            (
                new SetTextValue(SetText),
                new object[] { Text }
            );
        }
        
        public void Abort()
        {
            Th.Abort();
            Th.Join();
        }

        public void Work()
        {
            ThreadSetValue(0);
            try
            {
                uint Max = (uint)Bar.Maximum;
                double Sum = 0;
                for (uint i = 1; i <= Max; ++i)
                {
                    Sum += 1.0 / i;
                    //Thread.Sleep(1);
                    ThreadSetValue(i);
                }
                ThreadSetText(Max.ToString()+" -> "+Sum.ToString()+'\n');
                ThreadSetValue(0);
                Bar.Tag = null;
                ThreadSetButton(true);
            }
            catch (Exception)
            {
            }
        }
    }
}