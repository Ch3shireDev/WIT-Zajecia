using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalc
{
    class MatrixHelper
    {
        public static double[] ParseVector(string source)
        {
            string[] src = source.Split(" \t\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            double[] tb = new double[src.Length];
            for (int i = 0; i < tb.Length; ++i) tb[i] = double.Parse(src[i]);
            return tb;
        }
        public static double[,] ParseMatrix(string source)
        {
            double[,] tb = null;
            string[] rows = source.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int r = 0; r < rows.Length; ++r)
            {
                string[] cols = rows[r].Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r == 0) tb = new double[rows.Length,cols.Length];
                else if (cols.Length != tb.GetLength(1)) throw new ArgumentException("Różne rozmiary wierszy");
                for (int c = 0; c < cols.Length; ++c) tb[r, c] = double.Parse(cols[c]);
            }
            return tb;
        }
        public static double[] VectorMulMatrix(double[] vec,double[,] mat)
        {
            int rowcount = mat.GetLength(0);
            int colcount = mat.GetLength(1);
            if (vec.Length != colcount) throw new ArgumentException("Nieodpowiednie wymiary");
            double[] ret = new double[colcount];
            for(int r=0;r<rowcount;++r)
            {
                double sum = 0;
                for (int c = 0; c < colcount; ++c) sum += vec[c] * mat[r, c];
                ret[r] = sum;
            }
            return ret;
        }
        public static string ColumnToString(double[] col)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < col.Length; ++i)
            {
                /*///
                if (i != 0) sb.Append("\r\n");
                sb.Append(col[i]);
                /*/
                (i>0?sb.Append("\r\n"):sb).Append(col[i]);
                //*///
            }
            return sb.ToString();
        }

    }
}
