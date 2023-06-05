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
            AbjustButtons();
        }

        private string getTreningName()
        {
            return txtTreningName.Text.Trim();
        }
        private void AbjustButtons()
        {
            string TreningName = getTreningName();
            
            bool TreningNameNotEmpty = (TreningName.Length > 0);
            bool TreningListNotEmpty = (lbTrening.Items.Count > 0);
            bool TreningNameUnique = true;
            foreach (SportsmenCommand cmd in lbCommands.Items) if (cmd.ToString() == TreningName) TreningNameUnique = false;
            
            btnAppendCommands.Enabled = (TreningNameNotEmpty && TreningNameUnique && TreningListNotEmpty);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Sportsmen sporsmen = new Sportsmen("Jan Kowalski");
            SportsmenCommand run = new SportsmenCommandRun();
            SportsmenCommand jump = new SportsmenCommandJump();
            SportsmenCommand swim = new SportsmenCommandSwim();
            SportsmenCommand jsr = new SportsmenCommandTrening("jsr", new List<SportsmenCommand>() { jump,swim,run });
            SportsmenCommand jsr3 = new SportsmenCommandMultiply("jsr3", jsr, 3);

            txtLog.AppendText(sporsmen.execute(run) + Environment.NewLine);
            txtLog.AppendText(sporsmen.execute(jump) + Environment.NewLine);
            txtLog.AppendText(sporsmen.execute(swim) + Environment.NewLine);
            txtLog.AppendText(sporsmen.execute(jsr) + Environment.NewLine);
            txtLog.AppendText(sporsmen.execute(jsr3) + Environment.NewLine);
        }
    }
}
