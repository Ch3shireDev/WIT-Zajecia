using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test006
{
    class Month
    {
        private string[] m= {"sty","lut","mar","kwi","maj","cze","lip","sie","wrz","paź","lis","gru"};
        public string this[int index] { get { return m[(index - 1) % 12]; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] tb1 = new int[5];
            for (int i = 0; i < tb1.Length; ++i) tb1[i] = 10 * (i + 1);
            foreach (int val in tb1) Console.WriteLine("{0}", val);
            Console.WriteLine();

            int[][] tb2 = new int[5][];
            for (int i = 0; i < tb2.Length; ++i) tb2[i]=new int[1+i];
            foreach (int[] row in tb2)
            {
                foreach (int col in row) Console.Write("{0} ", col);
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] tb3 = new int[4, 5];
            for (int y = 0, i = 0; y < 4; ++y) for (int x = 0; x < 5; ++x) tb3[y, x]=++i;
            foreach (int val in tb3) Console.Write("{0} ", val);
            Console.WriteLine();
            Console.WriteLine();
            for (int y = 0; y <= tb3.GetUpperBound(0); ++y)
            {
                for (int x = 0; x <= tb3.GetUpperBound(1); ++x)
                {
                    Console.Write("{0} ", tb3[y,x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Wymiarów: {0}",tb3.Rank);
            Console.WriteLine();

            Month m = new Month();
            Console.WriteLine("Month 3 = {0}",m[3]);

            Console.ReadKey();
        }
    }
}
