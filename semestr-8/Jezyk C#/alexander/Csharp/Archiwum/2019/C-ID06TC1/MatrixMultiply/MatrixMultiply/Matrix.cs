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
            string[] content = text.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            double[,] result = null;
            int rows = content.Length;
            for (int y = 0; y < rows; ++y)
            {
                string[] row = content[y].Split(" ;\t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                int cols = row.Length;
                if (y == 0) result = new double[rows, cols];
                else if (result.GetLength(1) != cols) throw new ArgumentException("Different columns size");
                for (int x = 0; x < cols; ++x)
                {
                    if (!double.TryParse(row[x], out result[y, x]))
                    {
                        throw new ArgumentException(string.Format("Cells {0},{1} - \"{3}\" is not number", y, x, row[x]));
                    }
                }
            }
            if (result == null) throw new ArgumentException("Is not matrix");
            return result;
        }
        public double this[int row,int col]
        {
            get { return tb[row, col]; }
            set { tb[row, col] = value; }
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            int ysize = a.rows, xsize=b.cols;
            int zsize = a.cols, zzsize = b.rows;
            if (zsize != zzsize)
            {
                throw new ArgumentException
                (
                    string.Format
                    (
                        "Matrixes {0},{1} {2},{3} can't be multiplied", 
                        ysize, zsize, zzsize, xsize
                    )
                );
            }
            double[,] c = new double[ysize, xsize];
            for (int y = 0; y < ysize; ++y)
            {
                for (int x = 0; x < xsize; ++x)
                {
                    double sum = 0;
                    for (int z = 0; z < zsize; ++z) sum += a.tb[y, z] * b.tb[z, x];
                    c[y, x] = sum;
                }
            }
            return new Matrix(c);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int ysize = tb.GetLength(0), xsize = tb.GetLength(1);
            for (int y = 0; y < ysize; ++y)
            {
                for (int x = 0; x < xsize; ++x)
                {
                    if (x > 0) sb.Append("\t");
                    sb.Append(string.Format("{0:F3}", tb[y, x]));
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
