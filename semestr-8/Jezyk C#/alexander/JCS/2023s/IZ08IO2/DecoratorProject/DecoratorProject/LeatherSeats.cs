using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car) { }
        public override string info() { return base.info() + " + Leather Seats"; }
        public override int price() { return base.price() + 4000; }
    }
}
