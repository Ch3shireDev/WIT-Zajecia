using System;
using System.Threading;
using System.Windows.Forms;

namespace Harmonic
{
    public partial class Harmonic : Form
    {
        private delegate void CalculateProc(ulong count);
        private delegate void AppendLineProc(String str);
        private ulong Count = 0;
        public Harmonic()
        {
            InitializeComponent();
            ECount_TextChanged(null, null);
        }

        private void ECount_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled = ulong.TryParse(ECount.Text, out Count);
        }

        private void AppendLine(String str)
        {
            EResult.AppendText(str + Environment.NewLine);
        }

        private void AppendLineInvoke(String str)
        {
            //Invoke(new AppendLineProc(AppendLine), new object[] { str });
            Invoke(new Action(() => AppendLine(str))); // Lambda
        }

        private void Calculate(ulong count)
        {
            double sum = 0;
            for (ulong i = 1; i <= count; ++i) sum += 1.0 / i;
            AppendLineInvoke(count.ToString() + ": " + sum.ToString());
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            //new Thread(new ParameterizedThreadStart(CalculateObj)).Start(Count); // Wersja 1
            //new ThreadCall(Calculate, Count).Start(); // Wersja 2
            new Thread(() => Calculate(Count)).Start(); // Lambda
            ECount.SelectAll();
            ECount.Focus();
        }

        private void CalculateObj(object count) // Do wersji 1
        {
            Calculate((ulong)count);
        }

        private class ThreadCall // Do wersji 2
        {
            public delegate void CalculateProc(ulong count);
            public CalculateProc job;
            public ulong count;

            public ThreadCall(CalculateProc job,ulong count)
            {
                this.job = job;
                this.count = count;
            }

            public void Start() { new Thread(run).Start(); }

            private void run() { job(count); }
        }
    }
}
