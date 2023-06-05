using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalc
{
    public partial class MatrixCalcForm : Form
    {
        public MatrixCalcForm()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double[] var = MatrixHelper.ParseVector(EdVar.Text);
            double[,] mat = MatrixHelper.ParseMatrix(EdMatrix.Text);
            double[] ret = MatrixHelper.VectorMulMatrix(var, mat);
            EdRusult.Text = MatrixHelper.ColumnToString(ret);
        }
    }
}
