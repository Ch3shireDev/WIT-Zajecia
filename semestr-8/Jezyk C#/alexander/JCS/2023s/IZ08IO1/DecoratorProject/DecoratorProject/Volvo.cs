using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class Volvo : Car
    {
        public string info() { return "Volvo"; }

        public int price() { return 50000; }
    }
}
