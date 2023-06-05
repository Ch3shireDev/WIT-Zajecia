using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    delegate Car CarMaker();
    delegate Car CarDecoratorMaker(Car car);
    abstract class Car
    {
        public abstract String info();
        public abstract double price();
    }
    abstract class CarDecorator: Car
    {
        protected Car car;
        public CarDecorator(Car car) { this.car = car;  }
    }
    class Peugeot: Car
    {
        public override String info() { return "Peugeot"; }
        public override double price() { return 120000; }
    }
    class Mercedes : Car
    {
        public override String info() { return "Mercedes"; }
        public override double price() { return 80000; }
    }
    class Volvo : Car
    {
        public override String info() { return "Volvo"; }
        public override double price() { return 60000; }
    }
    class AirCondition : CarDecorator
    {
        public AirCondition(Car car) : base(car) { }
        public override String info() { return car.info() + " + Klimatyzacja"; }
        public override double price() { return car.price() + 8000; }
    }
    class TintedWindow : CarDecorator
    {
        public TintedWindow(Car car) : base(car) { }
        public override String info() { return car.info() + " + Tonowane szyby"; }
        public override double price() { return car.price() + 12000; }
    }
    class WinterTire : CarDecorator
    {
        public WinterTire(Car car) : base(car) { }
        public override String info() { return car.info() + " + Opony zimowe"; }
        public override double price() { return car.price() + 5000; }
    }
    class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car) { }
        public override String info() { return car.info() + " + Skórzane obicia"; }
        public override double price() { return car.price() + 15000; }
    }
    class CarList
    {
        private static Dictionary<string, CarMaker> map = makemap();
        private static Dictionary<string, CarMaker> makemap()
        {
            Dictionary<string, CarMaker> tmp = new Dictionary<string, CarMaker>();
            tmp.Add("Peugeot", () => { return new Peugeot(); });
            tmp.Add("Mercedes", () => { return new Mercedes(); });
            tmp.Add("Volvo", () => { return new Volvo(); });
            return tmp;
        }
        public static Car make(string kind)
        {
            return map[kind]();
            // CarMaker cm = map[kind]; return cm();
        }
        public static string[] list()
        {
            List<string> lst = map.Keys.ToList();
            lst.Sort();
            return lst.ToArray();
        }
    }
    class CarDecoratorList
    {
        private static Dictionary<string, CarDecoratorMaker> map = makemap();
        private static Dictionary<string, CarDecoratorMaker> makemap()
        {
            Dictionary<string, CarDecoratorMaker> tmp = new Dictionary<string, CarDecoratorMaker>();
            tmp.Add("Air Condition", (Car car) => { return new AirCondition(car); });
            tmp.Add("Tinted Window", (Car car) => { return new TintedWindow(car); });
            tmp.Add("Leather Seats", (Car car) => { return new LeatherSeats(car); });
            tmp.Add("Winter Tire", (Car car) => { return new WinterTire(car); });
            return tmp;
        }
        public static Car make(string kind, Car car)
        {
            return map[kind](car);
            // CarMaker cm = map[kind]; return cm();
        }
        public static string[] list()
        {
            List<string> lst = map.Keys.ToList();
            lst.Sort();
            return lst.ToArray();
        }
    }
}
