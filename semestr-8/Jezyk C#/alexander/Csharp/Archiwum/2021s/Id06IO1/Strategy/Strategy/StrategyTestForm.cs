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
    public partial class CommandTestForm : Form
    {
        public CommandTestForm()
        {
            InitializeComponent();
            lbCommands.Items.Add(new SportsmenCommandRun());
            lbCommands.Items.Add(new SportsmenCommandJump());
            lbCommands.Items.Add(new SportsmenCommandSwim());
            foreach (string kind in StrategyRunFactory.keys) cbRun.Items.Add(kind);
            foreach(string kind in StrategyJumpFactory.keys) cbJump.Items.Add(kind);
            foreach(string kind in StrategySwimFactory.keys) cbSwim.Items.Add(kind);
            lbCommands.SelectedIndex=0;
            cbRun.SelectedIndex=0;
            cbJump.SelectedIndex=0;
            cbSwim.SelectedIndex=0;
            AdjustButtons();
        }

        private void AdjustButtons()
        {
            string TreningName=txtTreningName.Text.Trim();
            bool TreningNameNotEmpty = (TreningName.Length>0);
            bool TreningNameNotUsed = true;
            foreach (SportsmenCommand cmd in lbCommands.Items) if (cmd.ToString() == TreningName) TreningNameNotUsed = false;
            bool TreningListNotEmpy = (lbTrening.Items.Count>0);
            btnAppendCommands.Enabled = (TreningNameNotEmpty && TreningNameNotUsed && TreningListNotEmpy);
        }

        private void txtTreningName_TextChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void txtSportsmenName_TextChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string sportsmenName=txtSportsmenName.Text.Trim();
            StrategyRun run=StrategyRunFactory.make(cbRun.SelectedItem.ToString());
            StrategyJump jump=StrategyJumpFactory.make(cbJump.SelectedItem.ToString());
            StrategySwim swim= StrategySwimFactory.make(cbSwim.SelectedItem.ToString());
            Sportsmen sportsmen=new Sportsmen(sportsmenName,run,jump,swim);
            SportsmenCommand cmd=(SportsmenCommand)lbCommands.SelectedItem;
            txtLog.AppendText(sportsmen.execute(cmd)+Environment.NewLine);
        }
    }
}
