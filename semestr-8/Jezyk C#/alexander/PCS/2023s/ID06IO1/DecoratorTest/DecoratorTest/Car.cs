using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    abstract class Car
    {
        public abstract string info();
        public abstract int price();
        public override string ToString()
        {
            return $"{price(),12}: {info()}";
        }
    }
}
