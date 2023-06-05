using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandTest
{
    public partial class CommandForm : Form
    {
        public CommandForm()
        {
            InitializeComponent();
            foreach(SportsmanCommand cmd in SportsmanCommandFabric.basic) LbCommands.Items.Add(cmd);
            LbCommands.SelectedIndex = 0;
            AdjustEnabled();
        }
        private void AdjustEnabled()
        {
            string SequenceName = EdSequenceName.Text.Trim();
            string MultiplyName = EdMultiply.Value + "x" + LbComplex.SelectedItem;
            bool ComplexEmpty = (LbComplex.Items.Count<=0);
            bool SequenceNameEmpty = (SequenceName.Length <= 0);
            bool SequenceNameUsed = false; //(LbCommands.Items.IndexOf(SequenceName) >= 0);
            bool MultiplyNameUsed = false; //(LbCommands.Items.IndexOf(MultiplyName) >= 0);
            bool SportsmenNameEmpty = (EdSportsmenName.Text.Length<=0);
            bool ComplexSelected = (LbComplex.SelectedIndices.Count>0);
            bool SelectedIsNotComplex = false;
            for(int i= 0; i< LbCommands.Items.Count;++i)
            {
                SportsmanCommand cmd = LbCommands.Items[i] as SportsmanCommand;
                string curr = cmd.ToString();
                if (!((cmd is SportsmanCommandTraining)|| (cmd is SportsmanCommandMultiply))) SelectedIsNotComplex = true;
                if (curr == SequenceName) SequenceNameUsed = true;
                if (curr == MultiplyName) MultiplyNameUsed = true;
            }
            BtnDelCommand.Enabled = !SelectedIsNotComplex;
            BtnDelComplex.Enabled = ComplexSelected;
            BtnStoreComplex.Enabled = !(ComplexEmpty || SequenceNameEmpty || SequenceNameUsed);
            BtnStoreMultiply.Enabled = !MultiplyNameUsed;
            BtnExecute.Enabled = !SportsmenNameEmpty;
        }
        private void EdComplexName_TextChanged(object sender, EventArgs e)
        {
            AdjustEnabled();
        }

        private void EdSportsmenName_TextChanged(object sender, EventArgs e)
        {
            AdjustEnabled();
        }

        private void LbCommands_SelectedValueChanged(object sender, EventArgs e)
        {
            AdjustEnabled();
        }

        private void LbComplex_SelectedValueChanged(object sender, EventArgs e)
        {
            AdjustEnabled();
        }
        private void LbCommands_Click(object sender, EventArgs e)
        {
            AdjustEnabled();
        }
        private void BtnDelCommand_Click(object sender, EventArgs e)
        {
            int pos = LbCommands.SelectedIndex;
            List<int> lst = new List<int>(LbCommands.SelectedIndices.Cast<int>());
            lst.Sort();
            for (int i = lst.Count - 1; i >= 0; --i) LbCommands.Items.RemoveAt(lst[i]);
            LbCommands.SelectedIndex = Math.Min(pos, LbCommands.Items.Count-1);
            LbCommands.Focus();
            AdjustEnabled();
        }

        private void BtnDelComplex_Click(object sender, EventArgs e)
        {
            int pos = LbComplex.SelectedIndex;
            List<int> lst = new List<int>(LbComplex.SelectedIndices.Cast<int>());
            lst.Sort();
            for (int i = lst.Count - 1; i >= 0; --i) LbComplex.Items.RemoveAt(lst[i]);
            LbComplex.SelectedIndex = Math.Min(pos, LbComplex.Items.Count - 1);
            LbComplex.Focus();
            AdjustEnabled();
        }

        private void BtnStoreComplex_Click(object sender, EventArgs e)
        {
            LbCommands.ClearSelected();
            int count = LbComplex.Items.Count;
            List<SportsmanCommand> lst = new List<SportsmanCommand>();
            for (int i = 0; i < count; ++i) lst.Add(LbComplex.Items[i] as SportsmanCommand);
            SportsmanCommand cmd = new SportsmanCommandTraining(EdSequenceName.Text, lst);
            int pos = LbCommands.Items.Count;
            LbCommands.Items.Add(cmd);
            LbCommands.SelectedIndex = pos;
            EdSequenceName.SelectAll();
            LbComplex.Items.Clear();
            LbCommands.Focus();
            AdjustEnabled();
        }

        private void BtnStoreMultiply_Click(object sender, EventArgs e)
        {
            LbCommands.ClearSelected();
            SportsmanCommand cmd = new SportsmanCommandMultiply((int)EdMultiply.Value,LbCommands.SelectedItem as SportsmanCommand);
            int pos = LbCommands.Items.Count;
            LbCommands.Items.Add(cmd);
            LbCommands.SelectedIndex = pos;
            LbCommands.Focus();
            AdjustEnabled();
        }

        private void BtnAddComplex_Click(object sender, EventArgs e)
        {
            List<int> lst = new List<int>(LbCommands.SelectedIndices.Cast<int>());
            LbComplex.ClearSelected();
            for (int i = 0; i < lst.Count; ++i)
            {
                int pos = LbComplex.Items.Count;
                LbComplex.Items.Add(LbCommands.Items[i] as SportsmanCommand);
                LbComplex.SelectedIndex = pos;
            }
            LbCommands.Focus();
            AdjustEnabled();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string name = EdSportsmenName.Text.Trim();
            Sportsman sm = new Sportsman(name);
            SportsmanCommand cmd = LbCommands.SelectedItem as SportsmanCommand;
            EdLog.AppendText(sm.execute(cmd) + Environment.NewLine);
            EdSportsmenName.SelectAll();
            LbCommands.Focus();
        }
    }
}
