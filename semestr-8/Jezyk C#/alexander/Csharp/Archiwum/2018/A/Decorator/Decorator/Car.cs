using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    delegate Car DecoratedCarMakeProc(Car car);
    abstract class Car
    {
        public abstract string info();
        public abstract double price();
    }
    abstract class DecoratedCar: Car
    {
        protected Car car;
        public DecoratedCar(Car car) { this.car = car; }
    }
    class Peugeot : Car
    {
        public override string info() { return "Peugeot"; }
        public override double price() { return 80000; }
    }
    class Volvo : Car
    {
        public override string info() { return "Volvo"; }
        public override double price() { return 80000; }
    }
    class Mercedes : Car
    {
        public override string info() { return "Mercedes"; }
        public override double price() { return 100000; }
    }
    class WinterTire : DecoratedCar
    {
        public WinterTire(Car car): base(car) { }
        public override string info() { return car.info() + " + Winter Tire"; }
        public override double price() { return car.price() + 12000; }
    }
    class Climatization : DecoratedCar
    {
        public Climatization(Car car) : base(car) { }
        public override string info() { return car.info() + " + Climatization"; }
        public override double price() { return car.price() + 5000; }
    }
    class LeatherSeats : DecoratedCar
    {
        public LeatherSeats(Car car) : base(car) { }
        public override string info() { return car.info() + " + Leather Seats"; }
        public override double price() { return car.price() + 8000; }
    }
    class TintedWindows : DecoratedCar
    {
        public TintedWindows(Car car) : base(car) { }
        public override string info() { return car.info() + " + Tinted Windows"; }
        public override double price() { return car.price() + 15000; }
    }
    interface CarMaker
    {
        Car make();
    }
    class CarMakerPeugeot: CarMaker
    {
        public Car make() { return new Peugeot(); }
    }
    class CarMakerVolvo : CarMaker
    {
        public Car make() { return new Volvo(); }
    }
    class CarMakerMercedes : CarMaker
    {
        public Car make() { return new Mercedes(); }
    }
    class CarList
    {
        private static Dictionary<string, CarMaker> map = makemap();
        private static Dictionary<string, CarMaker> makemap()
        {
            Dictionary<string, CarMaker> map = new Dictionary<string, CarMaker>();
            map.Add("Peugeot", new CarMakerPeugeot());
            map.Add("Volvo", new CarMakerVolvo());
            map.Add("Marcedes", new CarMakerMercedes());
            return map;
        }
        public static Car make(string key)
        {
            return map[key].make();
        }
        public static List<string> names()
        {
            List<string> list = map.Keys.ToList();
            list.Sort();
            return list;
        }
    }
    class DecoratedCarList
    {
        private static Dictionary<string, DecoratedCarMakeProc> map = makemap();
        private static Dictionary<string, DecoratedCarMakeProc> makemap()
        {
            Dictionary<string, DecoratedCarMakeProc> map = new Dictionary<string, DecoratedCarMakeProc>();
            map.Add("Winter Tire", (Car car) => { return new WinterTire(car); } );
            map.Add("Climatization", (Car car) => { return new Climatization(car); } );
            map.Add("Leather Seats", (Car car) => { return new LeatherSeats(car); });
            map.Add("Tinted Windows", (Car car) => { return new TintedWindows(car); });
            return map;
        }
        public static Car make(string key,Car car)
        {
            return map[key](car);
        }
        public static List<string> names()
        {
            List<string> list = map.Keys.ToList();
            list.Sort();
            return list;
        }
    }
}
