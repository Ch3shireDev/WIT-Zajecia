using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class Mercedes : Car
    {
        public string info() { return "Mercedes"; }
        public int price() { return 80000; }
    }
}
