using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmCalcSimple
{
    public partial class HarmCalcSimple : Form
    {
        private ulong count = 10000000000;
        public HarmCalcSimple()
        {
            InitializeComponent();
            EValue.Text = count.ToString();
        }

        private double calculate()
        {
            double sum = 0;
            for (ulong i = 1; i <= count; ++i) sum += 1.0 / i;
            return sum;
        }

        private void append(string str)
        {
            EResult.AppendText(str + Environment.NewLine);
        }

        private void EValue_TextChanged(object sender, EventArgs e)
        {
            BtnCalc.Enabled = UInt64.TryParse(EValue.Text.Trim(), out count);
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            append(count.ToString() + " -> " + calculate().ToString());
            EValue.SelectAll();
            EValue.Focus();
        }
    }
}
