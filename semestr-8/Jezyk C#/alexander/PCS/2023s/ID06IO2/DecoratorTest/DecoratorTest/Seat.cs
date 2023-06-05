using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class Seat : Car
    {
        public override string info() { return "Seat"; }
        public override int price() { return 55000; }
    }
}
