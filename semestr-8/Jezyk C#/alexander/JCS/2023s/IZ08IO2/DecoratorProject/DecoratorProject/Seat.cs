using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class Seat : Car
    {
        public string info() { return "Seat"; }
        public int price() { return 70000; }
    }
}
