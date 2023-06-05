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
        private static readonly Dictionary<bool, Color> GoodBackground = new Dictionary<bool, Color>()
        {
            {false, Color.Yellow},
            {true, SystemColors.Window},
        };
        private long Count = 100000000;
        public ControlsTestForm()
        {
            InitializeComponent();
            TbCount.Text = Count.ToString();
        }

        private void TbCount_TextChanged(object sender, EventArgs e)
        {
            bool good = long.TryParse(TbCount.Text, out Count);
            BtnCalculate.Enabled = good;
            TbCount.BackColor = GoodBackground[good];
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (long i = 1; i <= Count; ++i) sum += 1.0D / i;
            TbLog.AppendText(string.Format("{0,12}: {1,19:F16}",Count,sum)+Environment.NewLine);
            TbCount.SelectAll();
            TbCount.Focus();
        }
    }
}
