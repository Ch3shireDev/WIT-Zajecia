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
    public partial class CommandStrategyTestForm : Form
    {
        public CommandStrategyTestForm()
        {
            InitializeComponent();
            LbCommands.Items.Add(new SportsmanRun());
            LbCommands.Items.Add(new SportsmanJump());
            LbCommands.Items.Add(new SportsmanSwim());
            CbRun.Items.Add(new StrategyRunShort());
            CbRun.Items.Add(new StrategyRunMiddle());
            CbRun.Items.Add(new StrategyRunLong());
            CbJump.Items.Add(new StrategyJumpA());
            CbJump.Items.Add(new StrategyJumpB());
            CbJump.Items.Add(new StrategyJumpC());
            CbSwim.Items.Add(new StrategySwimFrog());
            CbSwim.Items.Add(new StrategySwimCrawl());
            CbSwim.Items.Add(new StrategySwimButterfly());
            CbRun.SelectedIndex = 1;
            CbSwim.SelectedIndex = 1;
            CbJump.SelectedIndex = 1;
            LbCommands.SelectedIndex = 0;
        }
        private SportsmanCommand CommandSelected() { return LbCommands.SelectedItem as SportsmanCommand; }
        private string GetTreningName() { return EdTrening.Text.Trim(); }
        private string GetSportsmenName() { return EdSportsman.Text.Trim(); }
        private bool UniqueCommandName(string name)
        {
            foreach (SportsmanCommand cmd in LbCommands.Items) if (cmd.ToString() == name) return false;
            return true;
        }
        private void SomeChanged()
        {
            string name = GetTreningName();
            bool HasTreningName = (name.Length > 0);
            bool HasSportsmanName = (GetSportsmenName().Length > 0);
            bool IsTreningNotEmpty = (LbTrening.Items.Count > 0);
            bool IsTreningSelected = (LbCommands.SelectedItem is SportsmanComposite);
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
            string name = GetSportsmenName();
            StrategyRun run = CbRun.SelectedItem as StrategyRun;
            StrategyJump jump = CbJump.SelectedItem as StrategyJump;
            StrategySwim swim = CbSwim.SelectedItem as StrategySwim;
            string report = new Sportsman(name, run, jump, swim).execute(CommandSelected());
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
        private StrategyRun run;
        private StrategyJump jump;
        private StrategySwim swim;
        public Sportsman(string Name,StrategyRun run,StrategyJump jump,StrategySwim swim)
        {
            this.Name = Name;
            this.run = run;
            this.jump = jump;
            this.swim = swim;
        }
        public string Run() { return run.execute(); }
        public string Jump() { return jump.execute(); }
        public string Swim() { return swim.execute(); }

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

    public interface SportsmanComposite : SportsmanCommand
    {
    }

    public class SportsmanMultiply : SportsmanComposite
    {
        private string Name { get; }
        public uint Count { get; }
        public SportsmanCommand Cmd { get; }
        public SportsmanMultiply(string Name, uint Count, SportsmanCommand Cmd)
        {
            this.Name = Name;
            this.Count = Count;
            this.Cmd = Cmd;
        }
        public string execute(Sportsman s)
        {
            return Count+"x" + Cmd.execute(s);
        }
        public override string ToString() { return Name; }
    }
    public class SportsmanTrening : SportsmanComposite
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

    public interface StrategySwim
    {
        string execute();
    }
    public interface StrategyRun
    {
        string execute();
    }
    public interface StrategyJump
    {
        string execute();
    }

    class StrategySwimCrawl : StrategySwim
    {
        public string execute() { return "kraul"; }
        public override string ToString() { return execute(); }
    }
    class StrategySwimFrog : StrategySwim
    {
        public string execute() { return "żabka"; }
        public override string ToString() { return execute(); }
    }
    class StrategySwimButterfly : StrategySwim
    {
        public string execute() { return "motylek"; }
        public override string ToString() { return execute(); }
    }
    class StrategyRunShort : StrategyRun
    {
        public string execute() { return "100m"; }
        public override string ToString() { return execute(); }
    }
    class StrategyRunMiddle : StrategyRun
    {
        public string execute() { return "1km"; }
        public override string ToString() { return execute(); }
    }

    class StrategyRunLong : StrategyRun
    {
        public string execute() { return "maraton"; }
        public override string ToString() { return execute(); }
    }

    class StrategyJumpA : StrategyJump
    {
        public string execute() { return "wysokość"; }
        public override string ToString() { return execute(); }
    }
    class StrategyJumpB : StrategyJump
    {
        public string execute() { return "dal"; }
        public override string ToString() { return execute(); }
    }
    class StrategyJumpC : StrategyJump
    {
        public string execute() { return "tyczka"; }
        public override string ToString() { return execute(); }
    }
}
