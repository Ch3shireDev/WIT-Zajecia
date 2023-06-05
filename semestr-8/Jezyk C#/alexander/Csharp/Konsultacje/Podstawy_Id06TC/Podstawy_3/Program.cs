using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_3
{
    public delegate void FooCall();
    public class Delegates
    {
        private event FooCall list;
        public static void FooStatic() { Console.WriteLine("FooStatic"); }
        public void FooNormal() { Console.WriteLine("FooNormal"); }

        public void testDelegate()
        {
            FooCall a = FooStatic; //Delegates.FooStatic;
            FooCall b = FooNormal; //this.FooNormal;
            FooCall c = () => Console.WriteLine("Lambda");
            a();
            b();
            c();
            list += () => Console.WriteLine("========================");
            list += FooStatic;
            list += FooNormal;
            list += () => Console.WriteLine("Lambda");
            list();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delegates d = new Delegates();
            d.testDelegate();

            Console.ReadLine();
        }
    }
}
