using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test003
{
    public class Frac
    {
        /*long fnom;
        public long nom
        {
            get 
            {
                return fnom; 
            } 
            set 
            {
                fnom = value; 
            } 
        }*/
        public static long nwd(long a,long b)
        {
            bool neg = false;
            if (a < 0) a = -a;
            if (b < 0)
            {
                b = -b;
                neg = true;
            }
            while(b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return neg?-a:a;
        }
        public long nom { get; set; }
        public long den { get; set; }
        public Frac(long nom,long den)
        {
            long n = nwd(nom, den);
            this.nom = nom/n;
            this.den = den/n;
        }
        public Frac(long value):this(value,1)
        {
        }
        public static Frac operator +(Frac a,Frac b)
        {
            return new Frac(a.nom*b.den+b.nom*a.den,a.den*b.den);
        }
        public static Frac operator -(Frac a, Frac b)
        {
            return new Frac(a.nom * b.den - b.nom * a.den, a.den * b.den);
        }
        public static Frac operator *(Frac a, Frac b)
        {
            return new Frac(a.nom * b.nom, a.den * b.den);
        }
        public static Frac operator /(Frac a, Frac b)
        {
            return new Frac(a.nom * b.den, a.den * b.nom);
        }

        public static Frac add(Frac a,Frac b)
        {
            return a+b;
        }
        public static Frac sub(Frac a, Frac b)
        {
            return a-b;
        }
        public static Frac mul(Frac a, Frac b)
        {
            return a*b;
        }
        public static Frac div(Frac a, Frac b)
        {
            return a/b;
        }

        public override string ToString()
        {
            return nom + "/" + den;
        }
        public static implicit operator Frac(string str)
        {
            string[] tb = str.Split(new char[] { '/' });
            if(tb.Length==2) return new Frac(long.Parse(tb[0]),long.Parse(tb[1]));
            if(tb.Length==1) return new Frac(long.Parse(tb[0]));
            throw new Exception("Wrong frac representation");
        }
        public delegate Frac Operation(Frac a,Frac b);
    }

    class Test003
    {
        public struct OperationFunc
        {
            public char op;
            public Frac.Operation func;
        }

        static void Main(string[] args)
        {
            OperationFunc[] tb = new OperationFunc[]
            {
                new OperationFunc { op = '+', func = Frac.add },
                new OperationFunc { op = '-', func = Frac.sub },
                new OperationFunc { op = '*', func = Frac.mul },
                new OperationFunc { op = ':', func = Frac.div }
            };
            while(true)
            { 
                string str = Console.ReadLine();
                bool err = true;
                //for (int i = 0; i < tb.Length; ++i)
                foreach (OperationFunc node in tb)
                {
                    string[] par = str.Split(new char[] { node.op });
                    if(par.Length==2)
                    {
                        Frac a = par[0], b = par[1];
                        Console.WriteLine("{0} {1} {2} = {3}", a, node.op, b, node.func(a, b));
                        err = false;
                        break;
                    }
                }
                if(err) Console.WriteLine("Unknown operation");
            }
        }
    }
}
