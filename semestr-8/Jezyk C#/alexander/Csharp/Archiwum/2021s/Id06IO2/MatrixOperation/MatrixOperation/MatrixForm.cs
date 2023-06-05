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
    public partial class MatrixForm : Form
    {
        public MatrixForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MatrixC.Text = (new Matrix(MatrixA.Text) + new Matrix(MatrixB.Text)).ToString();
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            MatrixB.Text = Matrix.solve(new Matrix(MatrixA.Text), new Matrix(MatrixC.Text)).ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            MatrixC.Text = (new Matrix(MatrixA.Text) * new Matrix(MatrixB.Text)).ToString();
        }
    }
}
