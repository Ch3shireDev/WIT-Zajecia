using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z002
{
    class z002
    {
        static double read(string msg)
        {
            while (true)
            {
                string str = "";
                try
                {
                    Console.Write(msg + ": ");
                    str = Console.ReadLine();
                    return Double.Parse(str);

                }
                catch (FormatException)
                {
                    if (str == "end") throw; // Environment.Exit(0); //
                    Console.WriteLine("Podaj liczbę lub wpisz słowo end" + Environment.NewLine);
                }
            }
        }
        static void Main(string[] args)
        {
            double[] tb = new double[10];
            while (true)
            {
                uint size;
                for (size = 0; size < tb.Length; ++size)
                {
                    try
                    {
                        tb[size] = read(String.Format("T[{0}]= ", size + 1));
                    }
                    catch (FormatException)
                    {
                        break;
                    }
                }
                if (size == 0) break;
                for (uint i = 0; i < size; ++i)
                {
                    Console.WriteLine("T[{0}] = {1}", i, tb[i]);
                }
                Console.WriteLine(Environment.NewLine);
                foreach (double v in tb)
                {
                    Console.WriteLine("{0}", v);
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
