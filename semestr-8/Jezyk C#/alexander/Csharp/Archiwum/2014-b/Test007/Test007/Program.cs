using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test007
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                uint Y, X;
                Console.Write("Podaj ilość wierszy: ");
                if ((!uint.TryParse(Console.ReadLine(), out Y))||(Y<=0)) break;
                Console.Write("Podaj ilość kolumn: ");
                if ((!uint.TryParse(Console.ReadLine(), out X))||(X<=0)) break;
                uint[,] tb=new uint[Y,X];

                for(uint S = Y + X -1, s = 0, i = 0; s < S; ++s)
                {
                    uint y = Y - 1, x = 0;
                    if (s <= y) y = s; else x = s - y;
                    while ((y < Y) && (x < X)) tb[y--, x++] = ++i;
                }

                string fmt = " {0,"+((int)(Math.Floor(Math.Log10(Y * X)) + 1)).ToString()+"}";
                for (uint y = 0; y < Y; ++y)
                {
                    for (uint x = 0; x < X; ++x)
                    {
                        Console.Write(fmt, tb[y,x]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
