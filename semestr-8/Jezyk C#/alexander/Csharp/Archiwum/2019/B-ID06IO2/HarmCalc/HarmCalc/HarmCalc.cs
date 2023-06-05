using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmCalc
{
    public partial class HarmCalc : Form
    {
        private ulong count= 10000000000UL;
        public HarmCalc()
        {
            InitializeComponent();
            EdCount.Text = count.ToString();
        }

        private void AppendText(string Line)
        {
            EdResults.AppendText(Line + Environment.NewLine);
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

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            AppendText(count.ToString() + " -> " + Calculate(count).ToString());
            EdCount.SelectAll();
            EdCount.Focus();
        }
    }
}
