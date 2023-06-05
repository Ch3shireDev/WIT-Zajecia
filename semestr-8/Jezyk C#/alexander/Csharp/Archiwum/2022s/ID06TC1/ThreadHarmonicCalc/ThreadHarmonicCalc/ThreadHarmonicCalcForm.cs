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

namespace ThreadHarmonicCalc
{
    delegate void AppendLogThreadDelegate(string method, ulong count, double result, DateTime dt);
    public partial class ThreadHarmonicCalcForm : Form
    {
        private ulong count = 400000000UL;
        public ThreadHarmonicCalcForm()
        {
            InitializeComponent();
            TbCount.Text = count.ToString();
        }

        private void TbCount_TextChanged(object sender,EventArgs e)
        {
            bool ok = ulong.TryParse(TbCount.Text, out count);
            BtnSimple.Enabled = BtnThread.Enabled = BtnParallel.Enabled = ok;
            TbCount.BackColor = ok ? SystemColors.Window : Color.Yellow;
        }

        private static double sum(ulong count)
        {
            // 1/1 + 1/2 + 1/3 ... 1/count
            double result = 0;
            for (ulong i = 1; i <= count; ++i) result += 1.0D / i;
            return result;
        }

        private void AppendLog(string method,ulong count,double result,DateTime dt)
        {
            if (InvokeRequired) AppendLogThread(method, count, result, dt);
            else TbLog.AppendText($"{method}: {count} => {result.ToString("F18")} ({dt.ToString("HH:mm:ss.ffffff")}){Environment.NewLine}");
        }

        private void AppendLogThread(string method, ulong count, double result, DateTime dt)
        {
            Invoke(new AppendLogThreadDelegate(AppendLog), new object[] { method, count, result, dt });
        }

        private void BtnSimple_Click(object sender, EventArgs e)
        {
            AppendLog("S", count, sum(count), DateTime.Now);
        }

        private void BtnThread_Click(object sender, EventArgs e)
        {
            new Thread(() => AppendLogThread("T", count, sum(count), DateTime.Now)).Start();
        }
    }
}
