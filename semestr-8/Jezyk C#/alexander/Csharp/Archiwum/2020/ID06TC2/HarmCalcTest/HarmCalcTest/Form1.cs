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
    delegate void AppendTextProc(string text);
    public partial class HarmCalcForm : Form
    {
        private static readonly ulong ThreadCount=4;
        private ulong Count;
        public HarmCalcForm()
        {
            InitializeComponent();
            EdCount.Text = 100000000.ToString();
        }
        private void AppendText(string text)
        {
            if (InvokeRequired) Invoke(new AppendTextProc(AppendText),new object[] { text });
            else EdLog.AppendText(text + Environment.NewLine);
        }
        private void AppenResult(double delta,string Method, ulong Count, double Result)
        {
            AppendText(string.Format("{0:F3}sec\t{1}\t{2}:\t{3:F18}", delta, Method, Count, Result));
        }
        private static double Calc(ulong Count)
        {
            double sum=0;
            for (ulong i = 1; i <= Count; ++i) sum += 1D / i;
            return sum;
        }
        private void CalcAndShow(long st, string Method)
        {
            ulong cnt = Count;
            double result = Calc(cnt);
            double delta = (DateTime.Now.Ticks - st) / 10000000D;
            AppenResult(delta, Method, cnt, result);
        }
        private double CalcPart(ulong Start, ulong Count)
        {
            double sum = 0;
            for (ulong i = Start + 1; i <= Count; i += ThreadCount) sum += 1D / i;
            return sum;
        }
        private double CalcMulti(ulong Count)
        {
            Thread[] th = new Thread[ThreadCount];
            double[] parts = new double[ThreadCount];
            for (ulong i = 0; i < ThreadCount; ++i)
            {
                ulong s = i; // koniecznie z powodu lambdy
                th[i] = new Thread(() => parts[s] = CalcPart(s, Count));
            }
            foreach (Thread t in th) t.Start();
            foreach (Thread t in th) t.Join();
            double sum = 0;
            foreach (double p in parts) sum += p;
            return sum;
        }
        private void CalcMultiAndShow(long st)
        {
            ulong cnt = Count;
            double result = CalcMulti(cnt);
            double delta = (DateTime.Now.Ticks - st) / 10000000D;
            AppenResult(delta, "mtc", cnt, result);
        }
        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            bool enabled = ulong.TryParse(EdCount.Text, out Count);
            BtnCalc.Enabled = enabled;
            BtnThreadCalc.Enabled = enabled;
            BtnMultiThreadCalc.Enabled = enabled;
        }
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            CalcAndShow(DateTime.Now.Ticks,"c");
            EdCount.SelectAll();
            EdCount.Focus();
        }
        private void BtnThreadCalc_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => CalcAndShow(DateTime.Now.Ticks, "tc"));
            th.Start();
            EdCount.SelectAll();
            EdCount.Focus();
        }
        private void BtnMultiThreadCalc_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => CalcMultiAndShow(DateTime.Now.Ticks));
            th.Start();
            EdCount.SelectAll();
            EdCount.Focus();
        }
    }
}
