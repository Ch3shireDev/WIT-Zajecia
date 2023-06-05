using System;
using System.Drawing;

namespace z001
{
    class z001
    {
        Point p;

        static double read(string msg)
        {
            while(true)
            {
                string str="";
                try
                {
                    Console.Write(msg+": ");
                    str = Console.ReadLine();
                    return Double.Parse(str);

                }
                catch(FormatException)
                {
                    if (str == "end") Environment.Exit(0); //throw;
                    Console.WriteLine("Podaj liczbę lub wpisz słowo end" + Environment.NewLine);
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                while(true)
                {
                    double a = read("Podaj wspolczynnik A"), b = read("Podaj wspolczynnik B"), c = read("Podaj wspolczynnik C");
                    if(a!=0)
                    {
                        double d = b * b - 4 * a * c;
                        if(d>0)
                        {
                            d = Math.Sqrt(d);
                            Console.WriteLine("x1={0} x2={1}" + Environment.NewLine, (-b + d) / (2 * a), (-b - d) / (2 * a));
                        }
                        else if(d==0)
                        {
                            Console.WriteLine("x={0}" + Environment.NewLine, -b / (2 * a));
                        }
                        else Console.WriteLine("Brak rozwiazań" + Environment.NewLine);
                    }
                    else if(b != 0)
                    {
                        Console.WriteLine("x={0}",-c/b);
                    }
                    else if (c != 0)
                    {
                        Console.WriteLine("Rownanie sprzeczne" + Environment.NewLine);
                    }
                    else Console.WriteLine("Rozwiązaniem jest dowolny x" + Environment.NewLine);
                }
            }
            catch(FormatException)
            {
            }
        }
    }
}
