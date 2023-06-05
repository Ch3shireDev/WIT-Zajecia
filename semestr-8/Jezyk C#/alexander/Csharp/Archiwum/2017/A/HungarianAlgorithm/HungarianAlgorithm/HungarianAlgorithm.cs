using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungarianAlgorithm
{
    class HungarianAlgorithm
    {
        private static double minInRow(double[,] mat, int row)
        {
            int size = mat.GetLength(1);
            double ret = mat[row, 0];
            for (int x = 1; x < size; ++x) if (ret > mat[row, x]) ret = mat[row, x];
            return ret;
        }
        private static double minInCol(double[,] mat, int col)
        {
            int size = mat.GetLength(0);
            double ret = mat[0, col];
            for (int y = 1; y < size; ++y) if (ret > mat[y, col]) ret = mat[y, col];
            return ret;
        }
        private static int findInRow(double[,] mat, bool[] markcol, int row)
        {
            int size = mat.GetLength(1);
            for (int x = 0; x < size; ++x) if (!markcol[x] && mat[row, x] == 0) return x;
            return -1;
        }
        private static int findInCol(double[,] mat, bool[] markrow, int col)
        {
            int ret = 0;
            int size = mat.GetLength(0);
            for (int y = 0; y < size; ++y) if (!markrow[y] && mat[y, col] == 0) return y;
            return -1;
        }
        private static int zerosInRow(double[,] mat, bool[] markcol, int row)
        {
            int ret = 0;
            int size = mat.GetLength(1);
            for (int x = 0; x < size; ++x) if (!markcol[x] && mat[row, x] == 0) ++ret;
            return ret;
        }
        private static int zerosInCol(double[,] mat, bool[] markrow, int col)
        {
            int ret = 0;
            int size = mat.GetLength(0);
            for (int y = 0; y < size; ++y) if (!markrow[y] && mat[y, col] == 0) ++ret;
            return ret;
        }
        private static int[] zerosInRows(double[,] mat, bool[] markcol)
        {
            int size = mat.GetLength(0);
            int[] counts = new int[size];
            for (int y = 0; y < size; ++y) counts[y] = zerosInRow(mat, markcol, y);
            return counts;
        }
        private static int[] zerosInCols(double[,] mat, bool[] markrow)
        {
            int size = mat.GetLength(1);
            int[] counts = new int[size];
            for (int x = 0; x < size; ++x) counts[x] = zerosInCol(mat, markrow, x);
            return counts;
        }
        private static double matMin(double[,] mat, bool[] markrow, bool[] markcol)
        {
            double ret = 0;
            int size = mat.GetLength(0);
            for (int y = 0; y < size; ++y)
            {
                if (!markrow[y])
                {
                    for (int x = 0; x < size; ++x)
                    {
                        if (!markcol[x] && ret > mat[y, x]) ret = mat[y, x];
                    }
                }
            }
            return ret;
        }
        private static bool haveZero(int[] tab)
        {
            for (int i = 0; i < tab.Length; ++i) if (tab[i] == 0) return true;
            return false;
        }
        private static int minNonZero(int[] tab)
        {
            int ret = -1;
            for (int i = 0; i < tab.Length; ++i)
            {
                if ((tab[i] > 0) && ((ret < 0) || (tab[ret] > tab[i]))) ret = i;
            }
            return ret;
        }
        private static bool markZero(double[,] mat, int[] indep)
        {
            int size = mat.GetLength(0);
            bool[] markrow = new bool[size];
            bool[] markcol = new bool[size];
            for (int z = 0; z < size; ++z)
            {
                int[] colzero = zerosInCols(mat, markrow);
                int[] rowzero = zerosInCols(mat, markcol);
                int mincol = minNonZero(colzero);
                int minrow = minNonZero(rowzero);
                if (mincol < minrow)
                {
                    int col = colzero.ToList().IndexOf(mincol);
                    if (col < 0) return false;
                    int row = findInCol(mat, markrow, col);
                    if (row < 0) return false;
                    markcol[col] = true;
                    markrow[row] = true;
                    indep[row] = col;
                }
                else
                {
                    int row = rowzero.ToList().IndexOf(minrow);
                    if (row < 0) return false;
                    int col = findInRow(mat, markcol, row);
                    if (col < 0) return false;
                    markcol[col] = true;
                    markrow[row] = true;
                    indep[row] = col;
                }
            }
            return true;
        }
        public static string matString(double[,] mat)
        {
            string ret = "";
            int size = mat.GetLength(0);
            for (int y = 0; y < size; ++y)
            {
                if (y > 0) ret += "\n";
                for (int x = 0; x < size; ++x)
                {
                    if (x > 0) ret += "\t";
                    ret += mat[y, x].ToString();
                }
            }
            return ret;
        }
        public static int[] Calc(double[,] mat)
        {
            int size = mat.GetLength(0);
            if (size != mat.GetLength(1)) return null;
            int[] indep=new int[size];
            // Step 2a
            for (int y = 0; y < size; ++y)
            {
                double vmin = minInRow(mat, y);
                for (int x = 0; x < size; ++x) mat[y, x] -= vmin;
            }
            // Step 2b
            for (int x = 0; x < size; ++x)
            {
                double vmin = minInCol(mat, x);
                for (int y = 0; y < size; ++y) mat[y, x] -= vmin;
            }
            while (true)
            {
                // Step 2
                if (markZero(mat, indep)) break;
                // Step 3
                bool[] markrow = new bool[size];
                bool[] markcol = new bool[size];
                for (int z = 0; z < size; ++z)
                {
                    int[] colzero = zerosInCols(mat, markrow);
                    int[] rowzero = zerosInCols(mat, markcol);
                    int maxcol = colzero.Max();
                    int maxrow = rowzero.Max();
                    if (maxcol > maxrow) markcol[colzero.ToList().IndexOf(maxcol)] = true;
                    else markrow[rowzero.ToList().IndexOf(maxrow)] = true;
                }
                // Step 4a
                double min = matMin(mat, markrow, markcol);
                // Step 4b
                for (int y = 0; y < size; ++y)
                {
                    bool fy = markrow[y];
                    for (int x = 0; x < size; ++x)
                    {
                        bool fx = markcol[x];
                        if (fy)
                        {
                            if (fx) mat[y, x] += min;
                        }
                        else
                        {
                            if (!fx) mat[y, x] -= min;
                        }
                    }
                }
            }
            return indep;
        }
    }
}
