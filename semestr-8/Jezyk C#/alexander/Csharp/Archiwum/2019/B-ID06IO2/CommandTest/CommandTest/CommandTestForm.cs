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
    public partial class CommandTestForm : Form
    {
        public CommandTestForm()
        {
            InitializeComponent();
            LbCommands.Items.Add(new SportsmanRun());
            LbCommands.Items.Add(new SportsmanJump());
            LbCommands.Items.Add(new SportsmanSwim());
            LbCommands.SelectedIndex = 0;
        }
        private SportsmanCommand CommandSelected() { return LbCommands.SelectedItem as SportsmanCommand; }
        private string GetTreningName() { return EdTrening.Text.Trim(); }
        private string GetSportsmenName() { return EdSportsman.Text.Trim(); }
        private bool UniqueCommandName(string name)
        {
            foreach (SportsmanCommand cmd in LbTrening.Items) if (cmd.ToString() == name) return false;
            return true;
        }
        private void SomeChanged()
        {
            string name = GetSportsmenName();
            bool HasTreningName = (name.Length > 0);
            bool HasSportsmanName = (GetSportsmenName().Length > 0);
            bool IsTreningNotEmpty = (LbTrening.Items.Count > 0);
            bool IsTreningSelected = (LbCommands.SelectedItem is SportsmanTrening);
            bool IsUniqueCommand = UniqueCommandName(name);
            BtnExecute.Enabled = HasSportsmanName;
            BtnDelFromTrening.Enabled = IsTreningNotEmpty;
            BtnDelFromCommands.Enabled = IsTreningSelected;
            BtnAddMultiply.Enabled = (IsUniqueCommand && HasTreningName);
            BtnAddTrening.Enabled = (IsUniqueCommand && HasTreningName && IsTreningNotEmpty);
        }
        private void DelFromListBox(ListBox lb)
        {
            int pos = lb.SelectedIndex;
            lb.Items.RemoveAt(pos);
            lb.SelectedIndex = Math.Min(pos, lb.Items.Count - 1);
            lb.Focus();
            SomeChanged();
        }
        private void SomeField_SomeChanged(object sender, EventArgs e)
        {
            SomeChanged();
        }
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string report=new Sportsman(GetSportsmenName()).execute(CommandSelected());
            EdLog.AppendText(report + Environment.NewLine);
        }
        private void BtnAddToTrening_Click(object sender, EventArgs e)
        {
            LbTrening.Items.Add(CommandSelected());
            LbTrening.SelectedIndex = LbTrening.Items.Count - 1;
            LbCommands.Focus();
        }
        private void BtnDelFromTrening_Click(object sender, EventArgs e)
        {
            DelFromListBox(LbTrening);
        }
        private void BtnDelFromCommands_Click(object sender, EventArgs e)
        {
            DelFromListBox(LbCommands);
        }
        private void BtnAddTrening_Click(object sender, EventArgs e)
        {
            int count = LbTrening.Items.Count;
            SportsmanCommand[] list = new SportsmanCommand[count];
            for (int i = 0; i < count; ++i) list[i] = LbTrening.Items[i] as SportsmanCommand;
            SportsmanCommand cmd = new SportsmanTrening(GetTreningName(), list);
            LbCommands.Items.Add(cmd);
            LbCommands.SelectedItem = cmd;
            LbTrening.Items.Clear();
            EdTrening.SelectAll();
            LbCommands.Focus();
            SomeChanged();
        }
        private void LbCommands_DoubleClick(object sender, EventArgs e)
        {
            SportsmanTrening cmd = CommandSelected() as SportsmanTrening;
            if(cmd != null)
            {
                EdTrening.Text = cmd.ToString();
                LbTrening.Items.Clear();
                foreach (SportsmanCommand item in cmd.List) LbTrening.Items.Add(item);
                LbTrening.SelectedIndex = 0;
                SomeChanged();
            }
        }

        private void BtnAddMultiply_Click(object sender, EventArgs e)
        {
            string name = GetTreningName();
            uint count = (uint)EdCount.Value;
            SportsmanCommand cmd = new SportsmanMultiply(name, count, CommandSelected());
            LbCommands.Items.Add(cmd);
            LbCommands.SelectedItem = cmd;
            EdTrening.SelectAll();
            LbCommands.Focus();
            SomeChanged();
        }
    }

    public class Sportsman
    {
        private string Name { get; set;  }
        public Sportsman(string Name) { this.Name = Name; }
        public string Run() { return "biegnę"; }
        public string Jump() { return "skaczę"; }
        public string Swim() { return "płynę"; }

        public string execute(SportsmanCommand cmd)
        {
            return Name + ": " + cmd.execute(this);
        }
    }

    public interface SportsmanCommand
    {
        string execute(Sportsman s);
    }

    public class SportsmanRun: SportsmanCommand
    {
        public string execute(Sportsman s) { return s.Run(); }
        public override string ToString() { return "bieg"; }
    }
    public class SportsmanJump : SportsmanCommand
    {
        public string execute(Sportsman s) { return s.Jump(); }
        public override string ToString() { return "skok"; }

    }
    public class SportsmanSwim : SportsmanCommand
    {
        public string execute(Sportsman s) { return s.Swim(); }
        public override string ToString() { return "pływanie"; }
    }
    public class SportsmanMultiply : SportsmanCommand
    {
        private string Name { get; set; }
        public uint Count { get; }
        public SportsmanCommand Cmd { get; }
        public SportsmanMultiply(string Name, uint Count, SportsmanCommand Cmd)
        {
            this.Name = Name;
            this.Cmd = Cmd;
        }
        public string execute(Sportsman s)
        {
            return Count+"x" + Cmd.execute(s);
        }
        public override string ToString() { return Name; }
    }
    public class SportsmanTrening : SportsmanCommand
    {
        private string Name { get; set; }
        public SportsmanCommand[] List { get; }
        public SportsmanTrening(string Name, SportsmanCommand[] List)
        {
            this.Name = Name;
            this.List = List;
        }
        public string execute(Sportsman s)
        {
            StringBuilder sb = new StringBuilder();
            foreach(SportsmanCommand cmd in List) sb.Append(cmd.execute(s)).Append('\t');
            return "("+sb.ToString().Trim().Replace("\t",", ")+")";
        }
        public override string ToString() { return Name; }
    }
}
