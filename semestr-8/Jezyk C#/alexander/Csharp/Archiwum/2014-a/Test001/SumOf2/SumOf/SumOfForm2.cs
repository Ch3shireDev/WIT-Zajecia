using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOf
{
    public partial class SumForm : Form
    {
        private static int backgroundCount=16;
        private BackgroundWorker[] bgArray = new BackgroundWorker[backgroundCount];
        private double[] PartialSum = new double[backgroundCount];
        private int MaxCount,DoneCount;
        public SumForm()
        {
            InitializeComponent();
            for(int i=0;i<backgroundCount;++i)
            {
                bgArray[i]=new BackgroundWorker();
                bgArray[i].WorkerReportsProgress = true;
                bgArray[i].WorkerSupportsCancellation = true;
                bgArray[i].DoWork += bgArrayDoWork;
                bgArray[i].RunWorkerCompleted += bgArrayCompleted;
                bgArray[i].ProgressChanged += bgArrayProgress;
            }
        }

        private void CountValue_TextChanged(object sender, EventArgs e)
        {
            int N = 0;
            if (int.TryParse(CountValue.Text, out N))
            {
                CountValue.ForeColor = System.Drawing.SystemColors.WindowText;
                BtnCalc.Enabled = true;
            }
            else
            {
                CountValue.ForeColor = Color.Red;
                BtnCalc.Enabled = false;
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            BtnCalc.Enabled = false;
            CountValue.Enabled = false;
            DoneCount = 0;
            if (int.TryParse(CountValue.Text, out MaxCount))
            {
                Progress.Maximum = MaxCount;
                for (int i = 0; i < backgroundCount; ++i) bgArray[i].RunWorkerAsync();
            }
            CountValue.SelectAll();
            CountValue.Focus();
        }

        private void bgArrayDoWork(object sender, DoWorkEventArgs e)
        {
            int p=0;
            while (sender != bgArray[p]) ++p;
            int mod = (MaxCount & 0xFFFF);
            double Sum = 0;
            for (int i=p+1; i <= MaxCount; i += backgroundCount)
            {
                Sum += 1.0 / i;
                if ((i & 0xFFFF) == mod)
                {
                    bgArray[p].ReportProgress(i);
                }
            }
            PartialSum[p] = Sum;
        }

        private void bgArrayCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (++DoneCount >= backgroundCount)
            {
                double Sum=0;
                for (int i = 0; i < backgroundCount; ++i) Sum += PartialSum[i];
                ResultValue.AppendText(CountValue.Text + " => " + Sum.ToString() + Environment.NewLine);
                Progress.Value = 0;
                CountValue.Enabled = true;
                BtnCalc.Enabled = true;
            }
        }

        private void bgArrayProgress(object sender, ProgressChangedEventArgs e)
        {
            if (Progress.Value < e.ProgressPercentage)
            {
                Progress.Value = e.ProgressPercentage;
            }
        }
    }
}
