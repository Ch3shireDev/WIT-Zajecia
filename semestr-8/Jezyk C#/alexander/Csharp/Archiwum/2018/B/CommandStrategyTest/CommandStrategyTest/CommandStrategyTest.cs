using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandStrategyTest
{
    public partial class CommandStrategyTest : Form
    {
        private Dictionary<string, Command> map = new Dictionary<string, Command>()
        {
            { "Run", new CommandRun() },
            { "Jump", new CommandJump() },
            { "Swim", new CommandSwim() },
        };
        public CommandStrategyTest()
        {
            InitializeComponent();
            UpdateCommandListbox();
            foreach (string str in StrategyRunList.names()) BoxRun.Items.Add(str);
            foreach (string str in StrategyJumpList.names()) BoxJump.Items.Add(str);
            foreach (string str in StrategySwimList.names()) BoxSwim.Items.Add(str);
            BoxRun.SelectedIndex = 0;
            BoxJump.SelectedIndex = 0;
            BoxSwim.SelectedIndex = 0;
        }
        private void UpdateCommandListbox()
        {
            object selected = LstMainList.SelectedItem;
            LstMainList.Items.Clear();
            List<string> lst = map.Keys.ToList();
            lst.Sort();
            foreach (string row in lst) LstMainList.Items.Add(row);
            int p = (selected == null) ? 0 : LstMainList.Items.IndexOf(selected);
            LstMainList.SelectedIndex = p < 0 ? 0 : p;
        }
        private void BtnAppend_Click(object sender, EventArgs e)
        {
            string row = LstMainList.SelectedItem.ToString();
            LstNewList.Items.Add(row);
            LstNewList.SelectedItem = row;
            LstMainList.Focus();
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int p=LstNewList.SelectedIndex;
            LstNewList.Items.Remove(LstNewList.SelectedItem);
            LstNewList.SelectedIndex = Math.Min(p, LstNewList.Items.Count - 1);
            LstNewList.Focus();
        }
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            Sportsman s = new Sportsman
            (
                EdName.Text.Trim(),
                StrategyRunList.make(BoxRun.SelectedItem.ToString()),
                StrategyJumpList.make(BoxJump.SelectedItem.ToString()),
                StrategySwimList.make(BoxSwim.SelectedItem.ToString())
            );
            Log.AppendText(map[LstMainList.SelectedItem.ToString()].Execute(s) + Environment.NewLine);
            LstMainList.Focus();
        }
        private void BtnMakeNew_Click(object sender, EventArgs e)
        {
            Command[] lst = new Command[LstNewList.Items.Count];
            int p = 0;
            foreach(string row in LstNewList.Items) lst[p++] = map[row];
            string title = EdNewName.Text.Trim();
            map.Add(title, new Trening(lst));
            UpdateCommandListbox();
            LstMainList.SelectedItem = title;
            LstMainList.Focus();
        }
        private void AdjustEnabled()
        {
            string title=EdNewName.Text.Trim();
            bool mainsel = LstMainList.SelectedIndex >= 0;
            bool newsel = LstNewList.SelectedIndex >= 0;
            bool newfill = LstNewList.Items.Count > 0;
            bool namegood = EdName.Text.Trim().Length > 0;
            bool titlegood = title.Length > 0;
            bool titleuniq = !map.ContainsKey(title);
            BtnAppend.Enabled = mainsel;
            BtnRemove.Enabled = newsel;
            BtnExecute.Enabled = mainsel && namegood;
            BtnMakeNew.Enabled = newfill && titlegood && titleuniq;
        }

        private void EdNewName_TextChanged(object sender, EventArgs e)
        {
            AdjustEnabled();
        }
        private void LstMainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustEnabled();
        }
        private void LstNewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustEnabled();
        }
        private void EdName_TextChanged(object sender, EventArgs e)
        {
            AdjustEnabled();
        }
    }
}
