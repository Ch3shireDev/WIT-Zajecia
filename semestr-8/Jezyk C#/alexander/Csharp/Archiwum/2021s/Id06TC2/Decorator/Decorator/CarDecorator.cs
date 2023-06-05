using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CarDecorator:Car
    {
        private Car car;
        public CarDecorator(Car car) { this.car = car; }
        public virtual int price() { return car.price(); }
        public virtual string info() { return car.info(); }
        public Car baseCar { get { return car is CarDecorator?((CarDecorator)car).baseCar:car; } }
    }
    public abstract class CarDecoratorFactory
    {
        private delegate Car maker(Car car);
        private static Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"Air Condition",(car)=>new AirCondition(car)},
            {"Leather Seats",(car)=>new LeatherSeats(car)},
            {"Tinted Window",(car)=>new TintedWindow(car)},
            {"Winter Tire",(car)=>new WinterTire(car)},
        };
        public static List<string> Kinds { get { return map.Keys.OrderBy((kind) => kind).ToList(); } }
        public static Car Make(string kind, Car car) { return map[kind](car); }
    }
    public class AirCondition:CarDecorator
    {
        public AirCondition(Car car) : base(car) { }
        public override int price() 
        {
            return base.price() + (baseCar is Mercedes ? 5300 : 5000);
        }
        public override string info() { return base.info()+" + Air Condition"; }
    }
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car) { }
        public override int price() { return base.price() + 9000; }
        public override string info() { return base.info() + " + Leather Seats"; }
    }
    public class TintedWindow : CarDecorator
    {
        public TintedWindow(Car car) : base(car) { }
        public override int price() { return base.price() + baseCar.tintedWindowPrice(); }
        public override string info() { return base.info() + " + Tinted Window"; }
    }
    public class WinterTire : CarDecorator
    {
        private static Dictionary<string, int> pricelist = new Dictionary<string, int>()
        {
            {typeof(Mercedes).Name,3900},
            {typeof(Volvo).Name,4500},
        };
        public WinterTire(Car car) : base(car) { }
        public override int price() 
        {
            int add=4000;
            try { add = pricelist[this.GetType().Name]; } catch(Exception) {}
            return base.price() + add; 
        }
        public override string info() { return base.info() + " + Winter Tire"; }
    }
}
