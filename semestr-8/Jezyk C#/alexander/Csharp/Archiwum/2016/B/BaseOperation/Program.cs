using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseOperation
{
    class Program
    {
        delegate Fraction Operator(Fraction a, Fraction b);
        static void Main(string[] args)
        {
            Dictionary<string, Operator> opr = new Dictionary<string, Operator>();
            opr.Add("+", (Fraction a, Fraction b) => { return a + b; });
            opr.Add("-", (Fraction a, Fraction b) => { return a - b; });
            opr.Add("*", (Fraction a, Fraction b) => { return a * b; });
            opr.Add(":", (Fraction a, Fraction b) => { return a / b; });
            
            while(true)
            {
                Console.Write("Podaj wyrażenie matematyczne (exit-koniec): ");
                string[] op = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Fraction a, b;
                if ((op.Length == 3) && (Fraction.TryParse(op[0], out a)) && (Fraction.TryParse(op[2], out b)))
                {
                    string key=op[1];
                    if(opr.ContainsKey(key)) Console.WriteLine("{0} {1} {2} = {3}", a, key, b, opr[key](a,b));
                    else Console.Write("Nieznana operacja");
                }
                else if ((op.Length == 1) && (op[0] == "exit")) return;
                else Console.Write("Niepoprawne wyrażenie");
            }
        }
    }
    class Fraction
    {
        private long nom, den;
        Fraction(long nom=0, long den=1)
        {
            if (den<0)
            {
                nom = -nom;
                den = -den;
            }
            long div = nwd(Math.Abs(nom), den);

            this.nom = nom / div;
            this.den = den / div;
        }
        public static bool TryParse(string line,out Fraction fr)
        {
            fr = new Fraction();
            string[] tb = line.Split('/');
            return (tb.Length == 2) && (long.TryParse(tb[0], out fr.nom)) && (long.TryParse(tb[1], out fr.den));
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}",nom,den);
        }
        public static Fraction operator +(Fraction a,Fraction b)
        {
            return new Fraction(a.nom * b.den + b.nom * a.den, a.den * b.den);
        }
        public static Fraction operator -(Fraction a,Fraction b)
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
        public static long nwd(long a, long b)
        {
            if ((a == 0) || (b == 0)) return 1;
            while(b!=0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
