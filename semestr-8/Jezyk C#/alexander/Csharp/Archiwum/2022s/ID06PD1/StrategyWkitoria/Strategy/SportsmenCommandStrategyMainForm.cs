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
            LbCommands.Items.Add(new SportsmenCommandJump());
            LbCommands.Items.Add(new SportsmenCommandRun());
            LbCommands.Items.Add(new SportsmenCommandSwim());
            LbCommands.SelectedIndex = 0;
            AdjustButtons();
        }

        private SportsmenCommand GetSelectedCommand() { return (SportsmenCommand)LbCommands.SelectedItem; }
        // select last index of listbox
        private void SelectLastIndex(ListBox box) { box.SelectedIndex = box.Items.Count - 1; }
        // get sportsman surname
        private string GetSportsmanSurname() { return TbSportsmenName.Text.Trim(); }
        // appends text to log
        private void AppendToLog(string text) { TbLog.AppendText(text + Environment.NewLine); }

        private string GetTrainingName() { return TbTreningName.Text.Trim(); }

        private void SelectIndex(ListBox box, int index) { box.SelectedIndex = Math.Min(index, box.Items.Count - 1); }

        private bool IsUniqueCommandName(string Name)
        {
            foreach (SportsmenCommand command in LbCommands.Items) if (Name == command.ToString()) return false;
            return true;
        }

        private void AdjustButtons()
        {
            string SportsmanSurname = GetSportsmanSurname();
            string TreningName = GetTrainingName();
            SportsmenCommand command = GetSelectedCommand();
            //=======================================================
            bool SportsmanSurnameNotEmpty = SportsmanSurname.Length > 0;
            bool TreningListNotEmpty = LbTrening.Items.Count > 0;
            bool TreningNameNotEmpty = TreningName.Length > 0;
            bool CommandNameIsUnique = IsUniqueCommandName(TreningName);
            bool SelectedCommandIsComplex = command is SportsmenCommandComplex;
            //=======================================================
            BtnExecute.Enabled = SportsmanSurnameNotEmpty;
            BtnRemoveFromTrening.Enabled = TreningListNotEmpty;
            BtnAddToCommands.Enabled = CommandNameIsUnique && TreningNameNotEmpty && TreningListNotEmpty;
            BtnRemoveFromCommands.Enabled = SelectedCommandIsComplex;
        }
        private void BtnAddToTrening_Click(object sender, EventArgs e)
        {
            SportsmenCommand command = GetSelectedCommand();
            LbTrening.Items.Add(command);
            SelectLastIndex(LbTrening);
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            // Sportsmen(string surname)
            // string execute(SportsmenCommand command)
            Sportsmen sportsmen = new Sportsmen(GetSportsmanSurname());
            string report = sportsmen.execute(GetSelectedCommand());
            AppendToLog(report);
        }

        private void BtnRemoveFromTrening_Click(object sender, EventArgs e)
        {
            //get selected index 
            int index = LbTrening.SelectedIndex;
            LbTrening.Items.RemoveAt(index);
            SelectIndex(LbTrening, index);
        }

        private void BtnAddToCommands_Click(object sender, EventArgs e)
        {
            //create trening with given name and comand list and add it to comand
            //new SportsmenCommandTraining(string name, List < SportsmenCommand > training)
            //get training name
            string name = GetTrainingName();
            List<SportsmenCommand> training = new List<SportsmenCommand>();
            foreach (SportsmenCommand command in LbTrening.Items) training.Add(command);
            SportsmenCommandTrening cmd = new SportsmenCommandTrening(name, training);
            LbCommands.Items.Add(cmd);
            SelectLastIndex(LbCommands);
        }

        private void BtnRemoveFromCommands_Click(object sender, EventArgs e)
        {
            int index = LbCommands.SelectedIndex;
            LbCommands.Items.RemoveAt(index);
            SelectIndex(LbCommands, index);
        }

        private void TbSportsmenName_TextChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void TbTreningName_TextChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void LbCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void LbTrening_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }
    }
}
