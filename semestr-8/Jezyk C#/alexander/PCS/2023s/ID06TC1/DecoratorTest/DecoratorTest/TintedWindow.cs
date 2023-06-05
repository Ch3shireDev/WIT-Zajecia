using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class TintedWindow : CarDecorator
    {
        public TintedWindow(Car car): base(car) { }
        public override string info() { return base.info() + " + Tinted Window"; }
        public override int price() { return base.price() + 5000; }
    }
}
