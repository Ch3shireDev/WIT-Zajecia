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
    public partial class ControlsTestFainForm : Form
    {
        private static readonly Dictionary<bool, Color> GoodColor = new Dictionary<bool, Color>()
        {
            {false, SystemColors.Info},
            {true,  SystemColors.Window}
        };
        private long Count = 10000000;
        public ControlsTestFainForm()
        {
            InitializeComponent();
            TbCount.Text = Count.ToString();
            //TbCount.TextChanged += TbCount_TextChanged;
        }

        private void TbCount_TextChanged(object sender, EventArgs e)
        {
            bool good = long.TryParse(TbCount.Text, out Count);
            BtnCalculate.Enabled = good;
            TbCount.BackColor = GoodColor[good];
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (long i=1; i<=Count; ++i) sum += 1d / i;
            TbResults.AppendText(string.Format("{0,12}: {1,19:F16}",Count,sum)+Environment.NewLine);
            TbCount.SelectAll();
            TbCount.Focus();
        }
    }
}
