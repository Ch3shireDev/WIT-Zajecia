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
    public partial class SportsmenCommandMainForm : Form
    {
        public SportsmenCommandMainForm()
        {
            InitializeComponent();
            LbCommands.Items.Add(new SportsmenCommandJump());
            LbCommands.Items.Add(new SportsmenCommandRun());
            LbCommands.Items.Add(new SportsmenCommandSwim());
            LbCommands.SelectedIndex = 0;
            CbStrategiesJump.Items.AddRange(SportsmenStrategyJumpFactory.Strategies);
            CbStrategiesJump.SelectedIndex = 0;
            CbStrategiesSwim.Items.AddRange(SportsmenStrategySwimFactory.Strategies);
            CbStrategiesSwim.SelectedIndex = 0;
            CbStrategiesRun.Items.AddRange(SportsmenStrategyRunFactory.Strategies);
            CbStrategiesRun.SelectedIndex = 0;
            AdjustButtons();
        }

        private string SportsmenName()
        {
            return TbSportsmenName.Text.Trim();
        }

        private string TreningName()
        {
            return TbTreningName.Text.Trim();
        }

        private SportsmenCommand SelectedCommand()
        {
            return LbCommands.SelectedItem as SportsmenCommand;
        }

        private bool CheckUniqueCommandName(string name)
        {
            //foreach(object i in LbCommands.Items)
            //{
            //    if(name == i.ToString())
            //    {
            //        return false;
            //    }
            //}
            foreach (object i in LbCommands.Items) if (name == i.ToString()) return false;
            return true;
        }

        private void AdjustButtons()
        {
            string surname = SportsmenName();
            string treningName = TreningName();
            SportsmenCommand selectedCommand = SelectedCommand();

            bool sportsmenNameNotEmpty = surname.Length > 0;
            bool treningListNotEmpty = LbTrening.Items.Count > 0;
            bool treningNameNotEmpty = treningName.Length > 0;
            bool uniqueCommandName = CheckUniqueCommandName(treningName);
            bool selectedCommandIsComplex = selectedCommand is SportsmenCommandComplex;


            BtnAddToCommands.Enabled = uniqueCommandName && treningListNotEmpty && treningNameNotEmpty;
            BtnExecute.Enabled = sportsmenNameNotEmpty;
            BtnRemoveFromCommands.Enabled = selectedCommandIsComplex;
            BtnRemoveFromTrening.Enabled = treningListNotEmpty;
        }

        private void BtnAddToTrening_Click(object sender, EventArgs e)
        {
            SportsmenCommand cmd = SelectedCommand();
            LbTrening.Items.Add(cmd);
            LbTrening.SelectedIndex = LbTrening.Items.Count-1;

        }

        private void BtnRemoveFromTrening_Click(object sender, EventArgs e)
        {
            int index = LbTrening.SelectedIndex;
            LbTrening.Items.RemoveAt(index);
            LbTrening.SelectedIndex = Math.Min(LbTrening.Items.Count - 1, index);
        }

        private void BtnAddToCommands_Click(object sender, EventArgs e)
        {
            List<SportsmenCommand> cmds = new List<SportsmenCommand>();
            for(int i = 0; i < LbTrening.Items.Count; ++i)
            {
                cmds.Add(LbTrening.Items[i] as SportsmenCommand);
            }
            string name = TreningName();
            SportsmenCommand trening = new SportsmenCommandTreining(name, cmds);
            LbCommands.Items.Add(trening);
            LbCommands.SelectedIndex = LbCommands.Items.Count - 1;
        }

        private void BtnRemoveFromCommands_Click(object sender, EventArgs e)
        {
            int index = LbCommands.SelectedIndex;
            LbCommands.Items.RemoveAt(index);
            LbCommands.SelectedIndex = Math.Min(LbCommands.Items.Count - 1, index);
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            //Sportsmen(string surname)
            //string execute(SportsmenCommand command)
            string surname = SportsmenName();
            SportsmenStrategyRun stRun = CbStrategiesRun.SelectedItem as SportsmenStrategyRun;
            SportsmenStrategyJump stJump = CbStrategiesJump.SelectedItem as SportsmenStrategyJump;
            SportsmenStrategySwim stSwim = CbStrategiesSwim.SelectedItem as SportsmenStrategySwim;
            // Sportsmen sportsmen = new Sportsmen(surname,(SportsmenStrategyRun) (CbStrategiesRun.SelectedItem), (SportsmenStrategyJump)(CbStrategiesJump.SelectedItem), (SportsmenStrategySwim)(CbStrategiesSwim.SelectedItem));
            Sportsmen sportsmen = new Sportsmen(surname, stRun, stJump, stSwim);    
            SportsmenCommand cmd = SelectedCommand();
            string raport = sportsmen.execute(cmd);
            TbLog.AppendText(raport + Environment.NewLine);
        }

        private void TbSportsmenName_TextChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void TbTreningName_TextChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void LbCommands_SelectedValueChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void LbTrening_SelectedValueChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }
    }
}
