﻿using System;
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
    public partial class CommandStrategyForm : Form
    {
        public CommandStrategyForm()
        {
            InitializeComponent();
            LbCommands.Items.Add(new SportsmenRun());
            LbCommands.Items.Add(new SportsmenJump());
            LbCommands.Items.Add(new SportsmenSwim());
            LbCommands.SelectedIndex = 0;
            CbRun.Items.AddRange(StrategyRunFabric.Keys());
            CbRun.SelectedIndex = 0;
            CbJump.Items.AddRange(StrategyJumpFabric.Keys());
            CbJump.SelectedIndex = 0;
            CbSwim.Items.AddRange(StrategySwimFabric.Keys());
            CbSwim.SelectedIndex = 0;
            AdjustEnabled();
        }
        private void AdjustEnabled()
        {
            string SequenceName = EdSequenceName.Text.Trim();
            string MultiplyName = EdMultiply.Value + "x" + LbComplex.SelectedItem;
            bool ComplexEmpty = (LbComplex.Items.Count<=0);
            bool SequenceNameEmpty = (SequenceName.Length <= 0);
            bool SequenceNameUsed = (LbCommands.Items.IndexOf(SequenceName) >= 0);
            bool MultiplyNameUsed = (LbCommands.Items.IndexOf(MultiplyName) >= 0);
            bool SportsmenNameEmpty = (EdSportsmenName.Text.Length<=0);
            bool SelectedIsComplex = LbCommands.SelectedItem is SportsmenComplexCommand;
            bool ComplexSelected = (LbComplex.SelectedItem != null);
            BtnDelCommand.Enabled = SelectedIsComplex;
            BtnDelComplex.Enabled = ComplexSelected;
            BtnStoreComplex.Enabled = !(ComplexEmpty || SequenceNameEmpty || SequenceNameUsed);
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
            LbCommands.Items.RemoveAt(pos);
            LbCommands.SelectedIndex = Math.Min(pos, LbCommands.Items.Count-1);
            LbCommands.Focus();
            AdjustEnabled();
        }

        private void BtnDelComplex_Click(object sender, EventArgs e)
        {
            int pos = LbComplex.SelectedIndex;
            LbComplex.Items.RemoveAt(pos);
            LbComplex.SelectedIndex = Math.Min(pos, LbComplex.Items.Count - 1);
            LbComplex.Focus();
            AdjustEnabled();
        }

        private void BtnStoreComplex_Click(object sender, EventArgs e)
        {
            int count = LbComplex.Items.Count;
            SportsmenCommand[] lst = new SportsmenCommand[count];
            for (int i = 0; i < count; ++i) lst[i] = LbComplex.Items[i] as SportsmenCommand;
            SportsmenCommand cmd = new SportsmenSequenceCommand(EdSequenceName.Text, lst);
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
            SportsmenCommand cmd = new SportsmenMultiplyCommand((int)EdMultiply.Value,LbCommands.SelectedItem as SportsmenCommand);
            int pos = LbCommands.Items.Count;
            LbCommands.Items.Add(cmd);
            LbCommands.SelectedIndex = pos;
            LbCommands.Focus();
            AdjustEnabled();
        }

        private void BtnAddComplex_Click(object sender, EventArgs e)
        {
            int pos = LbComplex.Items.Count;
            SportsmenCommand cmd = LbCommands.SelectedItem as SportsmenCommand;
            LbComplex.Items.Add(cmd);
            LbComplex.SelectedIndex = pos;
            LbCommands.Focus();
            AdjustEnabled();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string name = EdSportsmenName.Text.Trim();
            StrategyRun Run = StrategyRunFabric.Get(CbRun.SelectedItem.ToString());
            StrategyJump Jump = StrategyJumpFabric.Get(CbJump.SelectedItem.ToString());
            StrategySwim Swim = StrategySwimFabric.Get(CbSwim.SelectedItem.ToString());
            Sportsmen sm = new Sportsmen(name, Run, Jump, Swim);
            SportsmenCommand cmd = LbCommands.SelectedItem as SportsmenCommand;
            EdLog.AppendText(sm.execute(cmd) + Environment.NewLine);
            EdSportsmenName.SelectAll();
            LbCommands.Focus();
        }
    }
}
