using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixOperation
{
    public partial class MatrixOperationMainForm : Form
    {
        private Matrix matrixA = null, matrixB = null;
        public MatrixOperationMainForm()
        {
            InitializeComponent();
            TbMatrixesAB_TextChanged(null, null);
            ScRight.SplitterWidth = 8;
            ScLeft.SplitterWidth = 8;
        }

        private void ScLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScRight.SplitterDistance = ScLeft.SplitterDistance;
        }

        private void ScRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScLeft.SplitterDistance = ScRight.SplitterDistance;
        }

        private void TbMatrixesAB_TextChanged(object sender, EventArgs e)
        {
            bool FA = Matrix.TryParse(TbMatrixA.Text.Trim(), out matrixA);
            bool FB = Matrix.TryParse(TbMatrixB.Text.Trim(), out matrixB);
            bool F = FA && FB;
            BtnTest.Enabled = FA;
            BtnAdd.Enabled = F;
            BtnSub.Enabled = F;
            BtnMul.Enabled = F;
            BtnInv.Enabled = FA;
            BtnSolve.Enabled = F;
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            tbMatrixResult.Text = Matrix.Solve(matrixA, matrixB).ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            tbMatrixResult.Text = (matrixA + matrixB).ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            tbMatrixResult.Text = (matrixA - matrixB).ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            tbMatrixResult.Text = (matrixA * matrixB).ToString();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            tbMatrixResult.Text = matrixA.ToString();
        }
    }
}
