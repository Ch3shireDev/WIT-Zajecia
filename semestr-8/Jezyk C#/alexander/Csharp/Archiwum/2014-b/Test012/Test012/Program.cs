using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test012
{
    class Animal
    {
        private uint Id;
        private static uint SId=0;
        public Animal()
        {
            Id = ++SId;
        }
        public uint show(ref uint sum,string msg)
        {
            sum += Id;
            Console.WriteLine("I'm " + Id.ToString() + " (" + msg+")");
            return Id;
        }
    }

    class Program
    {
        delegate uint Command(ref uint sum, string msg);
        static void Main(string[] args)
        {
            Animal A = new Animal(), B = new Animal(), C = new Animal();
            Command list = delegate { return 0; };
            list += A.show;
            list += B.show;
            list += C.show;
            list += A.show;
            uint sum = 0;
            Console.WriteLine("Return value {0}", list(ref sum,"event").ToString());
            Console.WriteLine("Sum {0}", sum);
            Console.ReadKey();
        }
    }
}
