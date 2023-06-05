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
    public partial class ControlsTestMainForm : Form
    {
        private static readonly Dictionary<bool, Color> GoodColor = new Dictionary<bool, Color>()
        {
            {true, SystemColors.Window},
            {false, SystemColors.Info}
        };
        private ulong Count=10000000;
        public ControlsTestMainForm()
        {
            InitializeComponent();
            TbCount.Text = Count.ToString();
        }

        private void TbCount_TextChanged(object sender, EventArgs e)
        {
            bool good = ulong.TryParse(TbCount.Text, out Count);
            BtnCalculate.Enabled = good;
            TbCount.BackColor = GoodColor[good];
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (ulong i = 1; i <= Count; ++i) sum += 1d / i;
            //$"{Count}: {sum}";
            TbResults.AppendText(string.Format("{0,12}: {1,19:F16}", Count, sum)+Environment.NewLine);
            TbCount.SelectAll();
            TbCount.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TbResults.Clear();
        }
    }
}
