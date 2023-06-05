using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z011
{
    class Program
    {
        delegate void show(int a, int b);

        public static void par(int a, int b)
        {
            Console.WriteLine(a + " operacja " + b);
        }


        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            show s = delegate { }; // Pusty delegate
            s(0, 0);
            s += par;
            s += a.Plus;
            s += a.Minus;
            s += b.Multiply;
            s += b.Divide;
            s(1, 3);
            Console.ReadKey();
        }
    }
    class A
    {
        public void Plus(int a, int b)
        {
            Console.WriteLine(a + "+" + b + "=" + (a + b));
        }
        public void Minus(int a, int b)
        {
            Console.WriteLine(a + "-" + b + "=" + (a - b));
        }
    }
    class B
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine(a + "*" + b + "=" + (a * b));
        }
        public void Divide(int a, int b)
        {
            Console.WriteLine(a + "/" + b + "=" + (a / b));
        }
    }
}
