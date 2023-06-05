using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z003
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string str="";
                try
                {
                    Console.Write("Podaj wysokość: ");
                    str = Console.ReadLine();
                    uint Y = UInt32.Parse(str);
                    Console.Write("Podaj szerokość: ");
                    str = Console.ReadLine();
                    uint X = UInt32.Parse(str);
                    string fmt = "{0," + ((uint)Math.Floor(Math.Log10(Y * X)) + 2) + "}";
                    for (uint y = 0, i = 0; y < Y; ++y)
                    {
                        for (uint x = 0; x < X; ++x)
                        {
                            Console.Write(fmt, ++i);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    if (str == "end") return;
                    Console.WriteLine("Słowo end - kończy program" + Environment.NewLine);
                }
            }
        }
    }
}
