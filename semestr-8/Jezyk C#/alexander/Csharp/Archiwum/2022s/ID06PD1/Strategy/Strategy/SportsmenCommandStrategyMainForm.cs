using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class SportsmenCommandStrategyMainForm : Form
    {
        public SportsmenCommandStrategyMainForm()
        {
            InitializeComponent();
            CbStrategyRun.Items.AddRange(SportsmenStrategyRunFactory.strategies);
            CbStrategyRun.SelectedIndex = 0;
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            SportsmenStrategyRun stRun = CbStrategyRun.SelectedItem as SportsmenStrategyRun;
            //SportsmenStrategyRun stRun = (SportsmenStrategyRun)(CbStrategyRun.SelectedItem);
        }
    }
}
