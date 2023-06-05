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
    public partial class CommandTestForm : Form
    {
        public CommandTestForm()
        {
            InitializeComponent();
            AdjustButtons();
        }

        private void AdjustButtons()
        {
            string TreningName=txtTreningName.Text.Trim();
            bool TreningNameNotEmpty = (TreningName.Length>0);
            bool TreningNameNotUsed = true;
            foreach (string name in lbCommands.Items) if (name == TreningName) TreningNameNotUsed = false;
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
    }
}
