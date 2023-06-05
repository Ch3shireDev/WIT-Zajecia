using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class StrategyForm : Form
    {
        public StrategyForm()
        {
            InitializeComponent();
            lbCommands.Items.Add(new SportsmenCommandRun());
            lbCommands.Items.Add(new SportsmenCommandJump());
            lbCommands.Items.Add(new SportsmenCommandSwim());
            lbCommands.SelectedIndex=0;
            foreach(string kind in StrategyRunFactory.keys) cbRun.Items.Add(kind);
            cbRun.SelectedIndex=0;

        }

        private void btnAppendTrenig_Click(object sender, EventArgs e)
        {
            SportsmenCommand cmd=(SportsmenCommand)lbCommands.SelectedItem;
            lbTrening.Items.Add(cmd);
            lbTrening.SelectedIndex=lbTrening.Items.Count-1;
        }

        private void btnAppendCommand_Click(object sender, EventArgs e)
        {
            string TreningName=txtTreningName.Text.Trim();
            List<SportsmenCommand> list=new List<SportsmenCommand>();
            foreach(SportsmenCommand cmd in lbTrening.Items) list.Add(cmd);
            SportsmenCommand trening=new SportsmenCommandTrening(TreningName,list);
            lbCommands.Items.Add(trening);
            lbCommands.SelectedIndex=lbCommands.Items.Count-1;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string SportsmenName=txtSportsmenName.Text.Trim();
            StrategyRun run=StrategyRunFactory.get(cbRun.SelectedItem.ToString());
            SportsmenCommand cmd=(SportsmenCommand)lbCommands.SelectedItem;
            Sportsmen sportsmen=new Sportsmen(SportsmenName,run);
            txtLog.AppendText(sportsmen.execute(cmd)+Environment.NewLine);
        }
    }
}
