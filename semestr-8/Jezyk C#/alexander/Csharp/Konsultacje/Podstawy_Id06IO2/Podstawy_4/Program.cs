using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy_4
{
    public delegate void ShowProc();
    public class Delegates
    {
        private static event ShowProc list;
        public static void foo() { Console.WriteLine("static foo"); }
        public void Foo() { Console.WriteLine("nonstatic Foo"); }
        public static void Test1()
        {
            ShowProc s1 = () => Console.WriteLine("Lambda");
            s1();
            ShowProc s2 = Delegates.foo; // lub zwyczajnie foo
            s2();
            ShowProc s3 = new Delegates().Foo;
            s3();
            Console.WriteLine("==================");
            list += new ShowProc(() => Console.WriteLine("Lambda"));
            list += new ShowProc(foo);
            list += new ShowProc(new Delegates().Foo);
            list();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Delegates.Test1();
            Console.ReadLine();
        }
    }
}
