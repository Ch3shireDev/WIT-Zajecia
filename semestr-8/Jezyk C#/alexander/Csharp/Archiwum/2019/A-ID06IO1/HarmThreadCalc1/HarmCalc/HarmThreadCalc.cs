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

namespace HarmCalc
{
    public partial class HarmThreadCalc : Form
    {
        private delegate void AppendTextProc(string Line);
        private ulong count= 10000000000UL;

        public HarmThreadCalc()
        {
            InitializeComponent();
            EdCount.Text = count.ToString();
        }

        private void AppendText(string Line)
        {
            EdResults.AppendText(Line + Environment.NewLine);
        }
        private void InvokeAppendText(string Line)
        {
            Invoke(new AppendTextProc(AppendText), new object[] { Line });
        }
        private double Calculate(ulong count)
        {
            double sum = 0;
            for (ulong i = 1; i <= count; ++i) sum += 1.0 / i;
            return sum;
        }

        private void EdCount_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled=(ulong.TryParse(EdCount.Text, out count));
        }

        private void run()
        {
            ulong cnt=count;
            InvokeAppendText(String.Format("{0} -> {1:F13}",cnt,Calculate(cnt)));
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            new Thread(run).Start();
            EdCount.SelectAll();
            EdCount.Focus();
        }
    }
}
