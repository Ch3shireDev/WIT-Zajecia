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
    public partial class MatrixOperationForm : Form
    {
        public MatrixOperationForm()
        {
            InitializeComponent();
            ScLeft.SplitterWidth = 8;
            ScRight.SplitterWidth = 8;
        }

        private Matrix GetA() { return Matrix.Parse(TbMatrixA.Text.Trim()); }
        private Matrix GetB() { return Matrix.Parse(TbMatrixB.Text.Trim()); }

        private void ScLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScRight.SplitterDistance = ScLeft.SplitterDistance;
        }

        private void ScRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScLeft.SplitterDistance = ScRight.SplitterDistance;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            try { TbMatrixResult.Text = GetA().ToString(); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try { TbMatrixResult.Text = (GetA()+GetB()).ToString(); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }
        private void BtnSub_Click(object sender, EventArgs e)
        {
            try { TbMatrixResult.Text = (GetA() - GetB()).ToString(); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            try { TbMatrixResult.Text = (GetA() * GetB()).ToString(); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }

        private void BtnInv_Click(object sender, EventArgs e)
        {
            try { TbMatrixResult.Text = GetA().Inv().ToString(); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            try { TbMatrixResult.Text = Matrix.Solve(GetA(),GetB()).ToString(); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }
    }
}
