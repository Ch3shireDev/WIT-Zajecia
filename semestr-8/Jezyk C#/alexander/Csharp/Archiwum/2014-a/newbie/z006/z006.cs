using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z006
{
    class Program
    {
        static uint read(string msg)
        {
            while (true)
            {
                string str = "";
                try
                {
                    Console.Write(msg + ": ");
                    str = Console.ReadLine();
                    return UInt32.Parse(str);

                }
                catch (FormatException)
                {
                    if (str.ToUpper() == "END") Environment.Exit(0);
                    Console.WriteLine("Podaj liczbę lub wpisz słowo end" + Environment.NewLine);
                }
            }
        }
        static void rand(uint[,] Tb,Random rnd)
        {
            for (uint y = 0; y < Tb.GetLength(0); ++y)
            {
                for (uint x = 0; x < Tb.GetLength(1); ++x)
                {
                    Tb[y, x] = (uint)rnd.Next(1,9);
                }
            }
        }
        static uint allsum(uint[,] Tb)
        {
            uint sum = 0;
            for (uint y = 0; y < Tb.GetLength(0); ++y) for (uint x = 0; x < Tb.GetLength(1); ++x) sum += Tb[y, x];
            return sum;
        }
        static uint rowsum(uint[,] Tb,uint y)
        {
            uint sum = 0;
            for (uint x = 0; x < Tb.GetLength(1); ++x) sum+=Tb[y, x];
            return sum;
        }
        static uint colsum(uint[,] Tb, uint x)
        {
            uint sum = 0;
            for (uint y = 0; y < Tb.GetLength(0); ++y) sum += Tb[y, x];
            return sum;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while(true)
            {
                uint Y = read("Podaj wysokość"), X = read("Podaj szerokość");
                uint[,] Tb = new uint[Y, X];
                rand(Tb, rnd);
                uint sum = allsum(Tb);
                string fmt = "{0," + ((uint)Math.Floor(Math.Log10(sum)) + 2) + "}";
                for (uint y = 0; y < Tb.GetLength(0); ++y)
                {
                    for (uint x = 0; x < Tb.GetLength(1); ++x)
                    {
                        Console.Write(fmt, Tb[y, x]);
                    }
                    Console.WriteLine(fmt, rowsum(Tb, y));
                }
                for (uint x = 0; x < Tb.GetLength(1); ++x) Console.Write(fmt, colsum(Tb, x));
                Console.WriteLine(fmt + Environment.NewLine, sum);
            }
        }
    }
}
