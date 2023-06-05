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
    public partial class ControlsTestForm : Form
    {
        private static readonly Color[] GoodBg = new Color[] { Color.Yellow, SystemColors.Window };
        private long count=1000000000;
        private static Color GoodBgColor(bool ok) { return GoodBg[ok ? 1 : 0]; }
        public ControlsTestForm()
        {
            InitializeComponent();
            TbCount.Text = count.ToString();
        }
        private void TbCount_TextChanged(object sender, EventArgs e)
        {
            bool ok = long.TryParse(TbCount.Text, out count);
            BtnCalculate.Enabled = ok;
            TbCount.BackColor = GoodBgColor(ok);
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Ciąg harmoniczny
            // 1/1, 1/2, 1/3, 1/4, ... 1/N
            double sum=0;
            for (long i = 1; i <= count; ++i) sum += 1.0 / i;
            //TbLog.AppendText(count.ToString()+": "+sum.ToString()+Environment.NewLine);
            TbLog.AppendText(string.Format("{0,12}: {1:F16}",count,sum)+ Environment.NewLine);
            TbCount.SelectAll();
            TbCount.Focus();
        }
    }
}
