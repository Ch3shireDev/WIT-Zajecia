using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class Audi : Car
    {
        public override string info() { return "Audi"; }
        public override int price() { return 50000; }
    }
}
