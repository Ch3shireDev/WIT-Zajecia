using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class Toyota : Car
    {
        public string info() { return "Toyota"; }

        public int price() { return 30000; }
    }
}
