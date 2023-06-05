using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class Volvo : Car
    {
        public override string info() { return "Volvo"; }
        public override int price() { return 60000; }
    }
}
