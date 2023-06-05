using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z004
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
        static bool Check(ref string paramover, char id, char ch)
        {
            if(paramover.Contains(id))
            {
                Console.WriteLine("Niezgodny parametr {0}", ch);
                return false;
            }
            paramover += id;
            return true;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj parametry wyświetlenia (G/D L/P Z/N): ");
                string paramover = "", str = Console.ReadLine().ToUpper();
                if (str == "END") return;
                bool Vert = false, Horz = false, Spin = false, Error = false;
                foreach (char ch in str)
                {
                    if (ch == 'D') { if (Check(ref paramover, '|', ch)) Vert = true; else Error = true; }
                    else if (ch == 'G') { if (Check(ref paramover, '|', ch)) Vert = false; else Error = true; }
                    else if (ch == 'P') { if (Check(ref paramover, '-', ch)) Horz = true; else Error = true; }
                    else if (ch == 'L') { if (Check(ref paramover, '-', ch)) Horz = false; else Error = true; }
                    else if (ch == 'Z') { if (Check(ref paramover, '@', ch)) Spin = true; else Error = true; }
                    else if (ch == 'N') { if (Check(ref paramover, '@', ch)) Spin = false; else Error = true; }
                    else
                    {
                        Console.WriteLine("Nieznany parametr {0}", ch);
                        Error = true;
                    }
                }
                if (Error) continue;
                Spin ^= (Vert ^ Horz);
                uint Y = read("Podaj wysokość"), X = read("Podaj szerokość");
                string fmt = "{0," + ((uint)Math.Floor(Math.Log10(Y * X)) + 2) + "}";
                for (uint y = 0; y < Y; ++y)
                {
                    for (uint x = 0; x < X; ++x)
                    {
                        uint py = Vert ? Y - y - 1 : y, px = Horz ? X - x - 1 : x;
                        Console.Write(fmt, (Spin ? py * X + px : px * Y + py) + 1);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
