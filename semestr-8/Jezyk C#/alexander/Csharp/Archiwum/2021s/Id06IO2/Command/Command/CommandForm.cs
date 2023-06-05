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
            AdjustButtons();
        }

        private void AdjustButtons()
        {
            string TreningName = txtTreningName.Text.Trim();
            bool TreningNameEmpty = (TreningName.Length <= 0);
            bool TreningListEmpty = (lbTrening.Items.Count <= 0);
            bool TreningNameUsed = lbCommands.Items.Contains(TreningName);

            btnAppendCommand.Enabled=(!TreningNameEmpty && !TreningNameUsed && !TreningListEmpty);

        }
    }
}
