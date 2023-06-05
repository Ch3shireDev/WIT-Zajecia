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

namespace HarmCalcSimple
{
    delegate void AppendStringProc(string str);
    public partial class HarmCalcThread : Form
    {
        private ulong count = 1000000000;
        public HarmCalcThread()
        {
            InitializeComponent();
            EValue.Text = count.ToString();
        }

        private double calculate(ulong count)
        {
            double sum = 0;
            for (ulong i = 1; i <= count; ++i) sum += 1.0 / i;
            return sum;
        }

        private void append(string str)
        {
            EResult.AppendText(str + Environment.NewLine);
        }

        private void InvokeAppend(string str)
        {
            Invoke(new AppendStringProc(append), new object[] { str });
        }

        private void EValue_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled = UInt64.TryParse(EValue.Text.Trim(), out count);
        }

        private void RunThreadCalc(ulong count)
        {
            InvokeAppend(count.ToString() + " -> " + calculate(count).ToString());
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            new Thread(() => RunThreadCalc(count)).Start();
            EValue.SelectAll();
            EValue.Focus();
        }
    }
}
