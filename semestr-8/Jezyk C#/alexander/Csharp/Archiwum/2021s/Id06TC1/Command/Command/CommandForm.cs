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
    public partial class CommandForm : Form
    {
        public CommandForm()
        {
            InitializeComponent();
            lbCommands.Items.Add(new SportsmenCommandRun());
            lbCommands.Items.Add(new SportsmenCommandJump());
            lbCommands.Items.Add(new SportsmenCommandSwim());
            lbCommands.SelectedIndex=0;
            AbjustButtons();
        }
        private bool IsComandsNotExists(string name)
        {
            bool notexists = true;
            foreach (SportsmenCommand cmd in lbCommands.Items) if (cmd.ToString() == name) notexists = false;
            return notexists;
        }

        private void AbjustButtons()
        {
            string TreningName = txtTreningName.Text.Trim();

            bool TreningNameNotEmpty = (TreningName.Length > 0);
            bool TreningListNotEmpty = (lbTrening.Items.Count > 0);
            bool TreningNameUnique = IsComandsNotExists(TreningName);

            btnAppendCommand.Enabled = (TreningNameNotEmpty && TreningListNotEmpty && TreningNameUnique);
            //btnRemoveFromTrening.Enabled = (TreningListNotEmpty);
        }
        private void btnAppendTrenig_Click(object sender, EventArgs e)
        {
            SportsmenCommand cmd=(SportsmenCommand)lbCommands.SelectedItem;
            lbTrening.Items.Add(cmd);
            lbTrening.SelectedIndex=lbTrening.Items.Count-1;
            AbjustButtons();
        }

        private void btnAppendCommand_Click(object sender, EventArgs e)
        {
            string TreningName=txtTreningName.Text.Trim();
            List<SportsmenCommand> list=new List<SportsmenCommand>();
            foreach(SportsmenCommand cmd in lbTrening.Items) list.Add(cmd);
            SportsmenCommand trening=new SportsmenCommandTrening(TreningName,list);
            lbCommands.Items.Add(trening);
            lbCommands.SelectedIndex=lbCommands.Items.Count-1;
            AbjustButtons();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string SportsmenName=txtSportsmenName.Text.Trim();
            SportsmenCommand cmd=(SportsmenCommand)lbCommands.SelectedItem;
            Sportsmen sportsmen=new Sportsmen(SportsmenName);
            txtLog.AppendText(sportsmen.execute(cmd)+Environment.NewLine);
        }

        private void txtField_TextChanged(object sender, EventArgs e)
        {
            AbjustButtons();
        }
    }
}
