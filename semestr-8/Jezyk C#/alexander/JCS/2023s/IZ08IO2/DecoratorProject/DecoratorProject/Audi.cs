using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class Audi : Car
    {
        public string info() { return "Audi"; }
        public int price() { return 40000; }
    }
}
