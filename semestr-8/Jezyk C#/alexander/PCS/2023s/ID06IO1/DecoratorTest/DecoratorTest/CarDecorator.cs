using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    abstract class CarDecorator : Car
    {
        private Car car;
        public CarDecorator(Car car) { this.car = car; }
        public override string info() { return car.info(); }
        public override int price() { return car.price(); }
    }
}
