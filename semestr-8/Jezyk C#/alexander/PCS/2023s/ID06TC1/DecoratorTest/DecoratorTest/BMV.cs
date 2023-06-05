using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class BMV : Car
    {
        public string info() { return "BMV"; }
        public int price() { return 99000; }
    }
}
