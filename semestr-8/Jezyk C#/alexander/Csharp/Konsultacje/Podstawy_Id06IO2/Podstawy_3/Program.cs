using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_3
{
    class Program
    {
        public interface Add { double add(double a, double b); }
        public interface Sub { double sub(double a, double b); }

        public interface Mul { double execute(double a, double b); }
        public interface Div { double execute(double a, double b); }

        public interface Base { void callBase(); }
        public interface Extra : Base { void callExtra(); }

        public class Super:Extra
        {
            public void callBase() { Console.WriteLine("call base"); }
            public void callExtra() { Console.WriteLine("call extra"); }
        }

        public class Calc : Add, Sub, Mul, Div
        {
            public double add(double a, double b) { return a + b; }
            public double sub(double a, double b) { return a - b; }
            double Mul.execute(double a, double b) { return a * b; }
            double Div.execute(double a, double b) { return a / b; }
        }

        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Add a = calc;
            Console.WriteLine(string.Format("a.add()={0}", a.add(2, 3)));
            //Console.WriteLine(string.Format("a.add()={0}", a.sub(2, 3))); // Add ne ma metody sub
            Sub s = calc;
            Console.WriteLine(string.Format("s.sub()={0}",s.sub(2, 3)));
            //Console.WriteLine(string.Format("s.sub()={0}", s.add(2, 3))); // Sub ne ma metody add
            Mul m = calc;
            Console.WriteLine(string.Format("m.execute()={0}", m.execute(2, 3)));
            Div d = calc;
            Console.WriteLine(string.Format("d.execute()={0}", d.execute(2, 3)));
            
            Console.WriteLine(string.Format("calc.add()={0}", calc.add(2, 3)));
            Console.WriteLine(string.Format("calc.sub()={0}", calc.sub(2, 3)));
            Console.WriteLine(string.Format("calc.mul()={0}", (calc as Mul).execute(2, 3)));
            Console.WriteLine(string.Format("calc.div()={0}", (calc as Div).execute(2, 3)));
            Console.ReadLine();
        }
    }
}
