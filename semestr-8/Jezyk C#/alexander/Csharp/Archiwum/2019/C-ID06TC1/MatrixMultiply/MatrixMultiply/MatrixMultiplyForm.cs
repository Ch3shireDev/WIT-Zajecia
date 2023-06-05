using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixMultiply
{
    public partial class MatrixMultiplyForm : Form
    {
        public MatrixMultiplyForm()
        {
            InitializeComponent();
        }
        
        private void EdMatrixes_TextChanged(object sender, EventArgs e)
        {
            Matrix A, B;
            try
            {
                A = new Matrix(EdMatrixA.Text);
            }
            catch(Exception ex)
            {
                EdResult.Text = "Matrix A: " + ex.Message;
                return;
            }
            try
            {
                B = new Matrix(EdMatrixB.Text);
            }
            catch (Exception ex)
            {
                EdResult.Text = "Matrix B: " + ex.Message;
                return;
            }
            try
            {
                EdResult.Text = (A * B).ToString();
            }
            catch (Exception ex)
            {
                EdResult.Text = "Wynik: " + ex.Message;
                return;
            }
        }
    }
}
