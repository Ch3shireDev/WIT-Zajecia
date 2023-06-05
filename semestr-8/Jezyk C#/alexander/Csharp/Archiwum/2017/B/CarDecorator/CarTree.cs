using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDecorator
{
    public abstract class BaseCar
    {
        protected abstract string about();
        protected abstract uint price();
        public string About { get { return about(); } }
        public uint Price { get { return price(); } }
        public override string ToString() { return about() + ": " + string.Format("{0:F2}", price()); }
    }
    public abstract class DecoratorCar: BaseCar
    {
        protected BaseCar car;
        public DecoratorCar(BaseCar car) { this.car = car; }
        protected override string about() { return car.About; }
        protected override uint price() { return car.Price; }
    }
    public class Volvo : BaseCar
    {
        protected override string about() { return "Volvo"; }
        protected override uint price() { return 45000; }
    }
    public class Mercedes: BaseCar
    {
        protected override string about() { return "Mercedes"; }
        protected override uint price() { return 60000; }
    }
    public class Peugeot : BaseCar
    {
        protected override string about() { return "Peugeot"; }
        protected override uint price() { return 90000; }
    }
    public class Climatization : DecoratorCar
    {
        public Climatization(BaseCar car) : base(car) { }
        protected override string about() { return base.about() + " + Climatization"; }
        protected override uint price() { return base.price() + 300; }
    }
    public class WinterTire : DecoratorCar
    {
        public WinterTire(BaseCar car) : base(car) { }
        protected override string about() { return base.about() + " + Winter Tire"; }
        protected override uint price() { return base.price() + 600; }
    }
    public class WindowTinting : DecoratorCar
    {
        public WindowTinting(BaseCar car) : base(car) { }
        protected override string about() { return base.about() + " + Window Tinting"; }
        protected override uint price() { return base.price() + 1200; }
    }
    public class CarFactory
    {
        public delegate BaseCar Maker();
        private static Dictionary<string, Maker> List = new Dictionary<string, Maker>()
        {
            {"Mersedes", () => { return new Mercedes(); } },
            {"Peugeot", () => { return new Peugeot(); } },
            {"Volvo", () => { return new Volvo(); } },
        };
        public static BaseCar MakeByName(string name)
        {
            return List[name]();
        }
        public static string[] Names()
        {
            return List.Select(x => x.Key).ToArray();
        }
    }
    public class DecoratorFactory
    {
        public delegate BaseCar Maker(BaseCar car);
        private static Dictionary<string, Maker> List = new Dictionary<string, Maker>()
        {
            {"Climatization", (car) => { return new Climatization(car); } },
            {"Winter Tire", (car) => { return new WinterTire(car); } },
            {"Window Tinting", (car) => { return new  WindowTinting(car); } },
        };
        public static BaseCar MakeByName(string name, BaseCar car)
        {
            return List[name](car);
        }
        public static string[] Names()
        {
            return List.Select(x => x.Key).ToArray();
        }
    }
}
