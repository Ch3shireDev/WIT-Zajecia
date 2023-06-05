using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                byte A, B;
                Console.Write("Podaj A: ");
                A = byte.Parse(Console.ReadLine());
                Console.Write("Podaj B: ");
                B = byte.Parse(Console.ReadLine());
                try
                {
                    try
                    { 
                        Console.WriteLine("{0} + {1} = {2}", A, B, checked((byte)(A + B)));
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Nastąpiło przepełnienie byte");
                        throw;
                    }
                }
                catch(OverflowException)
                {
                    Console.WriteLine("last catch");
                }
                finally
                {
                    Console.WriteLine("finally");
                }
            }
        }
    }
}
