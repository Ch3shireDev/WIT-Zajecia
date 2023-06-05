using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class CarDecorator:Car
    {
        private Car car;
        public CarDecorator(Car car) { this.car = car; }

        public virtual string info() { return car.info(); }

        public virtual int price() { return car.price(); }
    }
}
