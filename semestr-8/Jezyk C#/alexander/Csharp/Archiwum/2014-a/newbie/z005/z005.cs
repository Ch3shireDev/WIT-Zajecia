using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z005
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Tb=new double[5];
            long[] X = { 1, 2, 3 };
            double[,] Mat = new double[3,5];
            Random rnd=new Random();

            Console.WriteLine("{0}",Mat.Length);
            for (uint y = 0; y < Mat.GetLength(0); ++y)
            {
                for (uint x = 0; x < Mat.GetLength(1); ++x)
                {
                    Mat[y, x] = 10 * rnd.NextDouble() - 5;
                    Console.Write(" {0,5:F2}", Mat[y, x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            double[][] Tr = new double[5][];
            for (uint y = 0; y < Tr.Length; ++y) Tr[y] = new double[y + 1];
            for (uint y = 0; y < Tr.Length; ++y)
            {
                for (uint x = 0; x < Tr[y].Length; ++x)
                {
                    Tr[y][x] = rnd.NextDouble();
                    Console.Write(" {0,5:F2}", Tr[y][x]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
