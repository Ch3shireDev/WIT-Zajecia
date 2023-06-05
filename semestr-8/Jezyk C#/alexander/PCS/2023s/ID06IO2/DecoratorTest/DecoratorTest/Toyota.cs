using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class Toyota : Car
    {
        public override string info() { return "Toyota"; }
        public override int price() { return 70000; }
    }
}
