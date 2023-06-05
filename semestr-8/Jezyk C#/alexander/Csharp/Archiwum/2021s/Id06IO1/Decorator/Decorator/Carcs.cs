using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Car
    {
        public abstract string info();
        public abstract int price();

        public static List<string> keys { get { return ...; } }
    }

    public abstract class CarDecorator : Car
    {
        private Car car;
        public CarDecorator(Car car) { this.car = car; }
        public override string info() { return car.info(); }
        public override int price() { return car.price(); }
        public static List<string> keys { get { return ...; } }
    }

    public class AirCondition : CarDecorator
    {
        public AirCondition(Car car) : base(car) {}
        public override string info() { return base.info() + " + AirCondition"; }
        public override int price() { return base.price() + 5000; }
    }

    // AirCondition, LeatherSeats, TintedWWindow, WinterTire
    //Car car=new Mercedes();
    //car=new AirCondition(car);
    //car=new LeatherSeats(car);

    public class Mercedes : Car
    {
        public override string info() { return "Mercedes"; }
        public override int price() { return 90000; }
    }

    public class Peugeot : Car
    {
        public override string info() { return "Peugeot"; }
        public override int price() { return 120000; }
    }
    public class Volvo : Car
    {
        public override string info() { return "Volvo"; }
        public override int price() { return 50000; }
    }
}
