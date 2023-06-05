using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class Volvo : Car
    {
        public string info() { return "Volvo"; }
        public int price() { return 50000; }
    }
}
