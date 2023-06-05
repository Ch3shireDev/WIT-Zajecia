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

namespace HarmCalcTest
{
    delegate void AppendResultProc(string Text);
    public partial class HarmCalcForm : Form
    {
        private static readonly ulong ThreadMax = 4;
        private ulong Count;
        public HarmCalcForm()
        {
            InitializeComponent();
            EdCount.Text = 100000000.ToString();
        }
        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            bool Enabled = ulong.TryParse(EdCount.Text, out Count);
            BtnCalc.Enabled = Enabled;
            BtnThreadCalc.Enabled = Enabled;
            BtnMultiThreadCalc.Enabled = Enabled;
        }
        private static double Calc(ulong Count)
        {
            double sum = 0;
            for (ulong i = 1; i <= Count; ++i) sum += 1D / i;
            return sum;
        }
        private void AppendResult(string Text)
        {
            if (InvokeRequired) Invoke(new AppendResultProc(AppendResult), new object[] { Text });
            else EdLog.AppendText(Text + Environment.NewLine);
        }
        //private void AppendResultInvoke(string Text)
        //{
        //    Invoke(new AppendResultProc(AppendResult), new object[] { Text });
        //}
        private void CalcAndShow(ulong Count)
        {
            //AppendResultInvoke(string.Format("{0}:\t{1:F18}", Count, Calc(Count)));
            AppendResult(string.Format("sn {0}:\t{1:F18}", Count, Calc(Count)));
        }
        private void PartMultiCalcAndShow(ulong Start, ulong Count, double[] result)
        {
            double sum = 0;
            for (ulong i = Start + 1; i <= Count; i += ThreadMax) sum += 1D / i;
            result[Start] = sum;
        }
        private void PartMultiCalcAndShowOut(ulong Start, ulong Count, out double result)
        {
            double sum = 0;
            for (ulong i = Start + 1; i <= Count; i += ThreadMax) sum += 1D / i;
            result = sum;
        }
        private void MultiCalcAndShow(ulong Count)
        {
            Thread[] th = new Thread[ThreadMax];
            double[] result = new double[ThreadMax];
            for (ulong i = 0; i < ThreadMax; ++i)
            {
                ulong s = i;
                th[i] = new Thread(() => PartMultiCalcAndShow(s, Count, result));
            }
            foreach (Thread t in th) t.Start();
            foreach (Thread t in th) t.Join();
            double sum = 0;
            foreach (double r in result) sum += r;
            AppendResult(string.Format("mt {0}:\t{1:F18}", Count, sum));
        }
        private void MultiCalcAndShowOut(ulong Count)
        {
            Thread[] th = new Thread[ThreadMax];
            double[] result = new double[ThreadMax];
            for (ulong i = 0; i < ThreadMax; ++i)
            {
                ulong s = i;
                th[i] = new Thread(() => PartMultiCalcAndShowOut(s, Count, out result[s]));
            }
            foreach (Thread t in th) t.Start();
            foreach (Thread t in th) t.Join();
            double sum = 0;
            foreach (double r in result) sum += r;
            AppendResult(string.Format("mo {0}:\t{1:F18}", Count, sum));
        }
        //private void CalcAndShowObj(object Count)
        //{
        //    CalcAndShow((ulong)Count);
        //}
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            CalcAndShow(Count);
            EdCount.SelectAll();
            EdCount.Focus();
        }

        private void BtnThreadCalc_Click(object sender, EventArgs e)
        {
            //Thread th = new Thread(CalcAndShow);
            //th.Start();
            //new Thread(CalcAndShow(Count)).Start();
            //new Thread(new ParameterizedThreadStart(CalcAndShowObj)).Start(new object[] { Count });
            new Thread(() => CalcAndShow(Count)).Start();
            EdCount.SelectAll();
            EdCount.Focus();
        }

        private void BtnMultiThreadCalc_Click(object sender, EventArgs e)
        {
            new Thread(() => MultiCalcAndShow(Count)).Start();
            new Thread(() => MultiCalcAndShowOut(Count)).Start();
            EdCount.SelectAll();
            EdCount.Focus();
        }
    }
}
