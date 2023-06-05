using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort
{
    public partial class MergeSortForm : Form
    {
        private static Random rnd = new Random();
        public MergeSortForm()
        {
            InitializeComponent();
        }
        
        private static double[] ParseTable(string text)
        {
            string[] rows = text.Split(" \t\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            double[] ret = new double[rows.Length];
            for (int i = 0; i < ret.Length; ++i) ret[i] = double.Parse(rows[i]);
            return ret;
        }

        private static string FromString(double[] tb)
        {
            StringBuilder sb = new StringBuilder();
            foreach (double val in tb) sb.Append(val).Append(Environment.NewLine);
            return sb.ToString();
        }

        private static double[] Generate(int size)
        {
            double[] tb = new double[size];
            for (int i = 0; i < size; ++i) tb[i] = rnd.Next(1000000, 9000000) / 1000.0;
            return tb;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            EdSource.Text = FromString(Generate(1000));
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            EdResult.Text = FromString(Merge.Sort(ParseTable(EdSource.Text)));
        }
    }
}
