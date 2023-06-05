using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    delegate CarDecorator CarDecoratorMaker(Car car);
    abstract class CarDecorator : Car
    {
        private static Dictionary<string, CarDecoratorMaker> map = new Dictionary<string, CarDecoratorMaker>()
        {
            {"TintedWindow",(car)=>new TintedWindow(car) },
            {"WinterTire",(car)=>new WinterTire(car) },
            {"Climatisation",(car)=>new Climatisation(car) },
            {"LeatherSits",(car)=>new LeatherSits(car) },
        };
        private Car car;
        public CarDecorator(Car car) { this.car = car; }
        public override string info() { return car.info(); }
        public override int price() { return car.price(); }
        public static string[] keys()
        {
            /*///
            List<string> srt=map.Keys.ToList();
            srt.Sort();
            return srt.ToArray();
            /*///
            return map.Keys.OrderBy((s) => s).ToArray();
            //*///
        }
        public static Car make(string kind,Car car) { return map[kind](car); }
    }
    class TintedWindow : CarDecorator
    {
        public TintedWindow(Car car) : base(car) {}
        public override string info() { return base.info() + " + Tinted Window"; }
        public override int price() { return base.price() + 3000; }
    }
    class WinterTire : CarDecorator
    {
        public WinterTire(Car car) : base(car) { }
        public override string info() { return base.info() + " + Winter Tire"; }
        public override int price() { return base.price() + 1500; }
    }
    class Climatisation : CarDecorator
    {
        public Climatisation(Car car) : base(car) { }
        public override string info() { return base.info() + " + Climatisation"; }
        public override int price() { return base.price() + 5000; }
    }
    class LeatherSits: CarDecorator
    {
        public LeatherSits(Car car) : base(car) { }
        public override string info() { return base.info() + " + Leather Sits"; }
        public override int price() { return base.price() + 6000; }
    }
}
