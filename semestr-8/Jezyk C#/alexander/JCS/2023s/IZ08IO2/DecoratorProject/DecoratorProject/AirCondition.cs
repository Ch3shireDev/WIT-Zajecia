using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class AirCondition : CarDecorator
    {
        public AirCondition(Car car) : base(car) {}
        public override string info() { return base.info()+ " + Air Condition"; }
        public override int price() { return base.price() + 1000; }
    }
}
