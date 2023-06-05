using System;
using System.Collections.Generic;
using System.Text;

namespace Test004
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                uint Y=0,X=0;
                while (true)
                {
                    Console.Write("Podaj wysokoœæ: ");
                    if (uint.TryParse(Console.ReadLine(), out Y)) break;
                    else Console.WriteLine("Niepoprawna liczba");
                }
                if (Y == 0) break;
                while (true)
                {
                    Console.Write("Podaj szerokoœæ: ");
                    if (uint.TryParse(Console.ReadLine(), out X)) break;
                    else Console.WriteLine("Niepoprawna liczba");
                }
                if (X == 0) break;
                uint w = (uint)Math.Floor(Math.Log10(Y * X)) + 1;
                for (uint y = 0; y < Y; ++y)
                {
                    for (uint x = 0; x < X; ++x)
                    {
                        uint v = y * X + ( (y & 1) == 0 ? x : (X - x - 1)) + 1;
                        Console.Write("{0:D"+w+"} ", v);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
