using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface Car
    {
        string info();
        int price();
    }
    public abstract class CarFactory
    {
        private delegate Car maker();
        private static Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"Mercedes",()=>new Mercedes()},
            {"Peugeot",()=>new Peugeot()},
            {"Audi",()=>new Audi()},
            {"Volvo",()=>new Volvo()},
        };
        private static string[] keys = map.Keys.OrderBy((model) => model).ToArray();
        public static string[] Keys { get { return keys; } }
        public static Car Make(string model) { return map[model](); }
    }
    public class Mercedes : Car
    {
        public string info() { return "Mercedes"; }
        public int price() { return 90000; }
    }
    public class Peugeot : Car
    {
        public string info() { return "Peugeot"; }
        public int price() { return 1200000; }
    }
    public class Audi : Car
    {
        public string info() { return "Audi"; }
        public int price() { return 700000; }
    }
    public class Volvo : Car
    {
        public string info() { return "Volvo"; }
        public int price() { return 500000; }
    }
    public abstract class CarDecorator:Car
    {
        private Car car;
        public CarDecorator(Car car) { this.car = car;  }
        public virtual string info() { return car.info(); }
        public virtual int price() { return car.price(); }
    }
    public abstract class CarDecoratorFactory
    {
        private delegate Car maker(Car car);
        private static Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"AirCondition",(car)=>new AirCondition(car)},
            {"LeatherSeats",(car)=>new LeatherSeats(car)},
            {"WinterTire",(car)=>new WinterTire(car)},
            {"TintedWindow",(car)=>new TintedWindow(car)},
        };
        private static string[] keys = map.Keys.OrderBy((kind) => kind).ToArray();
        public static string[] Keys { get { return keys; } }
        public static Car Make(string kind,Car car) { return map[kind](car); }
    }
    public class AirCondition:CarDecorator
    {
        public AirCondition(Car car):base(car) {}
        public override string info() { return base.info() + " + Air Condition"; }
        public override int price() { return base.price() + 4000; }
    }
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car) { }
        public override string info() { return base.info() + " + Leather Seats"; }
        public override int price() { return base.price() + 9000; }
    }
    public class WinterTire : CarDecorator
    {
        public WinterTire(Car car) : base(car) { }
        public override string info() { return base.info() + " + Winter Tire"; }
        public override int price() { return base.price() + 9000; }
    }
    public class TintedWindow : CarDecorator
    {
        public TintedWindow(Car car) : base(car) { }
        public override string info() { return base.info() + " + Tinted Window"; }
        public override int price() { return base.price() + 9000; }
    }
}
