using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class WinterTire : CarDecorator
    {
        public WinterTire(Car car) : base(car) { }
        public override string info() { return base.info() + " + Winter Tire"; }
        public override int price() { return base.price() + 2000; }
    }
}
