using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsTest
{
    public partial class ControlsMainForm : Form
    {
        private static readonly Color[] GoodBg = new Color[] { Color.Yellow,SystemColors.Window };
        private long Count=1000000000;
        private static Color GoodBackground(bool ok) { return GoodBg[ok ? 1 : 0]; }
        public ControlsMainForm()
        {
            InitializeComponent();
            TbCount.Text = Count.ToString();
        }

        private void TbCount_TextChanged(object sender, EventArgs e)
        {
            bool ok = long.TryParse(TbCount.Text, out Count);
            BtnCalculate.Enabled = ok;
            TbCount.BackColor = GoodBackground(ok);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (long i = 1; i <= Count; ++i) sum += 1.0D / i;
            TbLog.AppendText(string.Format("{0,12}: {1,19:F16}",Count,sum) + Environment.NewLine);
            TbCount.SelectAll();
            TbCount.Focus();
        }
    }
}
