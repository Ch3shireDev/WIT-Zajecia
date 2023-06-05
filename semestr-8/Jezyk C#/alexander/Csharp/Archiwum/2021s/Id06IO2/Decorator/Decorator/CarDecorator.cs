using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CarDecorator:Car
    {
        private Car car;
        public CarDecorator(Car car) { this.car = car; }
        public virtual string info() { return car.info(); }
        public virtual int price() { return car.price(); }
    }

    public abstract class CarDecoratorFactory
    {
        private delegate Car Maker(Car car);
        private static Dictionary<string, Maker> map = new Dictionary<string, Maker>()
        {
            {"Air Condition",(car) => new AirCondition(car) },
            {"Winter Tire",(car) => new WinterTire(car) },
            {"Leather Seats",(car) => new LeatherSeats(car) },
            {"Tinted Window",(car) => new TintedWindow(car) },
        };
        public static string[] Decorators { get { return map.Keys.OrderBy((decor) => decor).ToArray(); } }
        public static Car Make(string decor,Car car) { return map[decor](car); }
    }

    public class AirCondition : CarDecorator
    {
        private Car car;
        public AirCondition(Car car):base(car) {}
        public override string info() { return base.info()+ " + Air Condition"; }
        public override int price() { return base.price() + 3000; }
    }
    public class WinterTire : CarDecorator
    {
        private Car car;
        public WinterTire(Car car) : base(car) { }
        public override string info() { return base.info() + " + Winter Tire"; }
        public override int price() { return base.price() + 1000; }
    }
    public class LeatherSeats : CarDecorator
    {
        private Car car;
        public LeatherSeats(Car car) : base(car) { }
        public override string info() { return base.info() + " + Leather Seats"; }
        public override int price() { return base.price() + 9000; }
    }
    public class TintedWindow : CarDecorator
    {
        private Car car;
        public TintedWindow(Car car) : base(car) { }
        public override string info() { return base.info() + " + Tinted Window"; }
        public override int price() { return base.price() + 5000; }
    }
}
