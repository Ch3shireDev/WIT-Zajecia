using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungarianAlgorithm
{
    public partial class HungarianAlgorithmMainForm : Form
    {
        public HungarianAlgorithmMainForm()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            string[] text = Data.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int size = text.Length - 1;
            double[,] mat = new double[size, size];
            string[] worker = new string[size];
            string[] job = new string[size];
            string[] header = text[0].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            for (int y = 0; y < size; ++y)
            {
                job[y] = header[y + 1];
                string[] row = text[y + 1].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                worker[y] = row[0];
                for (int x = 0; x < size; ++x)
                {
                    mat[y, x] = double.Parse(row[x + 1]);
                }
            }
            int[] result = HungarianAlgorithm.Calc(mat);
            MessageBox.Show(HungarianAlgorithm.matString(mat));
        }
    }
}
