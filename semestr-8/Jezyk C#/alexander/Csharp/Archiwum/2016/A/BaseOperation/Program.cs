using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseOperation
{
    class Program
    {
        delegate string operation(Fraction a, Fraction b);
        /*
        static string div(Fraction a, Fraction b)
        {
            if (b != 0) return string.Format("{0} / {1} = {2}", a, b, a / b);
            else return "Cholero, nie dziel prze zero!";
        }
        */

        static void Main(string[] args)
        {
            Dictionary<string, operation> tb = new Dictionary<string, operation>();
            tb.Add("+", (Fraction a, Fraction b) => { return string.Format("{0} + {1} = {2}", a, b, a + b); });
            tb.Add("-", (Fraction a, Fraction b) => { return string.Format("{0} - {1} = {2}", a, b, a - b); });
            tb.Add("*", (Fraction a, Fraction b) => { return string.Format("{0} * {1} = {2}", a, b, a * b); });
            tb.Add(":", (Fraction a, Fraction b) => { return string.Format("{0} * {1} = {2}", a, b, a / b); });
            while (true)
            {
                Console.Write("Podaj wyrażenie: ");
                string[] values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if ((values.Length == 1) && (values[0].ToLower() == "exit")) return;
                else if (values.Length != 3) Console.WriteLine("Nieodpowiednia liczba parametrów");
                else
                {
                    Fraction a, b;
                    if (!Fraction.TryParse(values[0], out a)) Console.WriteLine("Pierwsze słowo musi być liczbą");
                    else if (!Fraction.TryParse(values[2], out b)) Console.WriteLine("Drugie słowo musi być liczbą");
                    else if (!tb.ContainsKey(values[1])) Console.WriteLine("Nieznana operacja");
                    else Console.WriteLine(tb[values[1]](a, b));

                    /*
                                        {
                                            switch(values[1])
                                            {
                                                case "+": Console.WriteLine("{0} + {1} = {2}", a, b, a + b); break;
                                                case "-": Console.WriteLine("{0} - {1} = {2}", a, b, a + b); break;
                                                case "*": Console.WriteLine("{0} * {1} = {2}", a, b, a + b); break;
                                                case "/":
                                                    {
                                                        if (b != 0) Console.WriteLine("{0} / {1} = {2}", a, b, a + b);
                                                        else Console.WriteLine("Cholero, nie dziel prze zero!");
                                                    }
                                                break;
                                            }
                                        }
                    */
                }
                Console.WriteLine();
            }
        }
    }

    class Fraction
    {
        private static long nwd(long a, long b)
        {
            if ((a == 0) || (b == 0)) return 1;
            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return b;
        }
        public long nom { get; }
        public long den { get; }
        public Fraction(long nom, long den)
        {
            if (den < 0)
            {
                den = -den;
                nom = -nom;
            }
            long r = nwd(nom, den);
            this.nom = nom / r;
            this.den = den / r;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.nom * b.den + b.nom * a.den, a.den * b.den);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.nom * b.den - b.nom * a.den, a.den * b.den);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.nom * b.nom, a.den * b.den);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.nom * b.den, a.den * b.nom);
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", nom, den);
        }
        public static bool TryParse(string str, out Fraction f)
        {
            string[] val = str.Split('/');
            long nom, den;
            if (val.Length == 1)
            {
                if (long.TryParse(val[0], out nom))
                {
                    f=new Fraction(nom, 1);
                    return true;
                }
            }
            else if (val.Length == 2)
            {
                if (long.TryParse(val[0], out nom) && long.TryParse(val[1], out den))
                {
                    f = new Fraction(nom, den);
                    return true;
                }
            }
            f = null;
            return false;
        }
    }
}
