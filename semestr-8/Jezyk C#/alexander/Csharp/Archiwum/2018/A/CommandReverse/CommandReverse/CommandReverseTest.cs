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
    public partial class CommandReverseTest : Form
    {
        private Dictionary<string,CommandClassic.Command> known=new Dictionary<string, CommandClassic.Command>();
        public CommandReverseTest()
        {
            InitializeComponent();
            known.Add("Run",new CommandClassic.RunCommand());
            known.Add("Swim",new CommandClassic.SwimCommand());
            known.Add("Jump",new CommandClassic.JumpCommand());
            RebuildAvailable();
        }
        private bool NameExists(string name)
        {
            return known.ContainsKey(name);
        }
        private CommandClassic.Command ByName(string name)
        {
            return known[name];
        }
        private void RebuildAvailable()
        {
            LstAvailable.Items.Clear();
            foreach(string str in known.Keys.OrderBy(str => str).ToList())
            {
                LstAvailable.Items.Add(str);
            }
        }
        private void AppendLog(string text)
        {
            Log.AppendText(text + Environment.NewLine);
        }
        private void BtnReverseTest_Click(object sender, EventArgs e)
        {
            AppendLog(CommandReverse.Test.test1());
        }

        private void BtnClassicTest_Click(object sender, EventArgs e)
        {
            AppendLog(CommandClassic.Test.test1());
            AppendLog(CommandClassic.Test.test2());
            AppendLog(CommandClassic.Test.test3());
            AppendLog(CommandClassic.Test.test4());
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string name = (string)LstAvailable.SelectedItem;
            CommandClassic.Command cmd = ByName(name);
            CommandReverse.Run run = new CommandReverse.Maraton();
            CommandReverse.Swim swim = new CommandReverse.Butterfly();
            CommandReverse.Jump jump = new CommandReverse.LongJump();
            CommandReverse.Sportsman man = new CommandReverse.Sportsman("Jasio", run, swim, jump);
            AppendLog(cmd.Execute(man));
        }

        private void BtnAppend_Click(object sender, EventArgs e)
        {
            string name = (string)LstAvailable.SelectedItem;
            LstTrening.Items.Add(name);
            LstAvailable.Focus();
            EdName_TextChanged(null, null);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int index = LstTrening.SelectedIndex;
            string name = (string)LstTrening.SelectedItem;
            LstTrening.Items.Remove(name);
            if (index >= LstTrening.Items.Count) index = LstTrening.Items.Count - 1;
            LstTrening.SelectedIndex = index;
            LstTrening.Focus();
            EdName_TextChanged(null, null);
        }

        private void EdName_TextChanged(object sender, EventArgs e)
        {
            string name = EdName.Text.Trim();
            BtnAdd.Enabled =
            (
                name.Length > 0
                &&
                !NameExists(name)
                &&
                LstTrening.Items.Count > 0
            );
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = EdName.Text.Trim();
            List<CommandClassic.Command> lst=new List<CommandClassic.Command>();
            foreach(string str in LstTrening.Items) lst.Add(ByName(str));
            CommandClassic.Command cmd = new CommandClassic.Trening(lst.ToArray());
            known.Add(name,cmd);
            RebuildAvailable();
            LstAvailable.SelectedItem = name;
            LstAvailable.Focus();
            EdName_TextChanged(null, null);
        }
    }
}
