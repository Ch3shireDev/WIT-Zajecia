using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalcTest
{
    public partial class MatrixCalcForm : Form
    {
        public MatrixCalcForm()
        {
            InitializeComponent();
        }

        private void LeftSplit_SplitterMoved(object sender, SplitterEventArgs e)
        {
            RightSplit.SplitterDistance = LeftSplit.SplitterDistance;
        }

        private void RightSplit_SplitterMoved(object sender, SplitterEventArgs e)
        {
            LeftSplit.SplitterDistance = RightSplit.SplitterDistance;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {

        }

        private void BtnGaus_Click(object sender, EventArgs e)
        {

        }
    }
}
