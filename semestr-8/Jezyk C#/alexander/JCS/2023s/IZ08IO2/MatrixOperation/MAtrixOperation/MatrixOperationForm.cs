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
        }

        private Matrix GetA()
        {
            return Matrix.Parse(TbMatrixA.Text.Trim());
        }
        private Matrix GetB()
        {
            return Matrix.Parse(TbMatrixB.Text.Trim());
        }
        private void SetResult(Matrix m)
        {
            TbMatrixResult.Text = m.ToString();
        }
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
            try { SetResult(GetA()); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try { SetResult(GetA() + GetB()); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            try { SetResult(GetA() - GetB()); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            try { SetResult(GetA() * GetB()); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }

        private void BtnInv_Click(object sender, EventArgs e)
        {
            try { SetResult(GetA().Inv()); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            try { SetResult(GetA().Solve(GetB())); }
            catch (Exception ex) { TbMatrixResult.Text = ex.Message; }
        }
    }
}
