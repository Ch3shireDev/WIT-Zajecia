using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiply
{
    class Matrix
    {
        public double[,] tb { get; set; }
        public Matrix(double[,] tb) { this.tb = tb; }
        public Matrix(string text) { this.tb = Split(text); }
        public int rows { get { return tb.GetLength(0); } }
        public int cols { get { return tb.GetLength(1); } }
        private static double[,] Split(string text)
        {

            double[,] result = null;

            return result;
        }
        public double this[int row,int col]
        {
            get { return tb[row, col]; }
            set { tb[row, col] = value; }
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
			int ysize=;
			int xsize=;
//
            double[,] c = new double[ysize, xsize];
//
            return new Matrix(c);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
//
            return sb.ToString();
        }
    }
}
