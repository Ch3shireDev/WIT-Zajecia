using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace test022
{
    public partial class Form1 : Form
    {
        delegate void SetText(string Text);
        private Random rnd = new Random();
        private List<Thread> PLst = new List<Thread>(),KLst = new List<Thread>();
        public Form1()
        {
            InitializeComponent();
            PCount_ValueChanged(null, null);
            KCount_ValueChanged(null, null);
        }

        void SetTextBox(string Text)
        {
            if (InvokeRequired) Invoke(new SetText(SetTextBox), new object[] { Text });
            else Box.Text = Text;
        }

        private void PProc()
        {
            while (true)
            {
                lock (Box) { SetTextBox(Box.Text + (char)('A' + rnd.Next(26))); }
                Thread.Sleep(400 + rnd.Next(500));
            }
        }

        private void KProc()
        {
            while (true)
            {
                lock (Box) { SetTextBox(Box.Text.Substring(1)); }
                Thread.Sleep(500 + rnd.Next(500));
            }
        }

        private void PCount_ValueChanged(object sender, EventArgs e)
        {
            while (PLst.Count < PCount.Value)
            {
                PLst.Add(new Thread(PProc));
                PLst.Last().Start();
            }
            while (PLst.Count > PCount.Value)
            {
                PLst.Last().Abort();
                PLst.Remove(PLst.Last());
            }
        }

        private void KCount_ValueChanged(object sender, EventArgs e)
        {
            while (KLst.Count < KCount.Value)
            {
                KLst.Add(new Thread(KProc));
                KLst.Last().Start();
            }
            while (KLst.Count > KCount.Value)
            {
                KLst.Last().Abort();
                KLst.Remove(KLst.Last());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread t in PLst) t.Abort();
            foreach (Thread t in KLst) t.Abort();
            foreach (Thread t in PLst) t.Join();
            foreach (Thread t in KLst) t.Join();
        }
    }
}
