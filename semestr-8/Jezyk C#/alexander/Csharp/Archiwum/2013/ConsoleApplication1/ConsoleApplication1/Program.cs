using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public delegate void Delegacja();
        public static void Metoda1()
        {
            Console.WriteLine("Została wywołana metoda Metoda1.");
        }
        public static void Metoda2(string napis)
        {
            Console.WriteLine("Została wywołana metoda Metoda2.");
        }
        public static void Main()
        {
            Delegacja del1 = Metoda1;
            //Delegacja del2 = Metoda2;
            del1();
            //del2();
            Console.ReadKey();
        }
    }
}
