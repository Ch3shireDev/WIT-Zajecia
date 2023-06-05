using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculatorMainForm : Form
    {
        InputControlDouble IcA, IcB;
        public SimpleCalculatorMainForm()
        {
            InitializeComponent();
            CbOperation.Items.AddRange(Operations.keys);
            CbOperation.SelectedIndex = 0;
            IcA = new InputControlDouble(TbValueA, Values_Changed, 0);
            IcB = new InputControlDouble(TbValueB, Values_Changed, 0);
            Values_Changed(null);
        }

        private void Values_Changed(InputControl source)
        {
            bool good
            =
                IcA != null && IcA.Good &&
                IcB != null && IcB.Good &&
                true
            ;
            if (good)
            {
                double R = Operations.calc
                (
                    IcA.Value,
                    CbOperation.SelectedItem.ToString(),
                    IcB.Value
                );
                TbResult.Text = R.ToString();
            }
            else TbResult.Text = "Error";
        }

        private void CbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Values_Changed(null);
        }
    }
}
