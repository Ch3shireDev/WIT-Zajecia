using System;
using System.Drawing;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;

namespace SumOf
{
    public partial class SumForm : Form
    {
        public SumForm()
        {
            InitializeComponent();
            ThreadPool.SetMinThreads(128, 4);
        }

        private void DoStartup(Worker Sender)
        {
            ProgressBarText Bar = new ProgressBarText();
            Sender.Bar = Bar;
            Bar.Tag = Sender;
            if (InvokeRequired)
            {
                Invoke(new Worker.WorkerEvent(DoStartup), Sender);
                return;
            }
            Bar.Dock = System.Windows.Forms.DockStyle.Top;
            Bar.Maximum = (int)Sender.Maximum;
            ProgressBox.Controls.Add(Bar);
        }

        private void DoProgress(Worker Sender)
        {
            if (!Sender.WaitFor) return;
            if (InvokeRequired)
            {
                Invoke(new Worker.WorkerEvent(DoProgress), Sender);
                return;
            }
            Sender.Bar.Increment(1);            
        }

        private void DoCompleted(Worker Sender)
        {
            if (!Sender.WaitFor) return;
            if (InvokeRequired)
            {
                Invoke(new Worker.WorkerEvent(DoCompleted), Sender);
                return;
            }
            ResultValue.AppendText(String.Format("{0} => {1,21:F18}", Sender.Count, Sender.Sum) + Environment.NewLine);
            ProgressBox.Controls.Remove(Sender.Bar);
            Sender.Bar = null; // nie koniecznie ale dla porządku
        }

        private void CountValue_TextChanged(object sender, EventArgs e)
        {
            uint Count = 0;
            bool ok = (uint.TryParse(CountValue.Text, out Count)) && (Count > 0);
            BtnCalc.Enabled = ok;
            if (ok) CountValue.ForeColor = System.Drawing.SystemColors.WindowText;
            else CountValue.ForeColor = Color.Red;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            uint Count;
            if (uint.TryParse(CountValue.Text, out Count)) new Worker(Count, DoStartup, DoProgress, DoCompleted);
            CountValue.SelectAll();
            CountValue.Focus();
        }

        private void SumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (ProgressBarText p in ProgressBox.Controls) ((Worker)p.Tag).WaitFor = false;
            foreach (ProgressBarText p in ProgressBox.Controls) while (((Worker)p.Tag).Bar != null) { }
        }
    }
}
