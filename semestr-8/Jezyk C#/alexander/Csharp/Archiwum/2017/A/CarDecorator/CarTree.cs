using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDecorator
{
    public abstract class BaseCar
    {
        public delegate BaseCar CarMaker();
        public delegate BaseCar DecoratorCarMaker(BaseCar car);
        protected abstract string about();
        protected abstract double price();
        public string About { get { return about(); } }
        public double Price { get { return price(); } }

        private static Dictionary<string, CarMaker> StrMakers = new Dictionary<string, CarMaker>()
        {
            {"Mercedes",() => { return new Mercedes(); } },
            {"Volvo", () => { return new Volvo(); } },
            {"Peugeot", () => { return new Peugeot(); } },
        };

        public static BaseCar MakeCarByName(string name)
        {
            return StrMakers[name]();
        }

        public static String[] CarNames()
        {
            string[] keys = new string[StrMakers.Count];
            uint i=0;
            foreach(var item in StrMakers) keys[i++]=item.Key;
            return keys;
        }

        private static Dictionary<string, DecoratorCarMaker> StrDecoratorMakers = new Dictionary<string, DecoratorCarMaker>()
        {
            {"Climatization",(car) => { return new Climatization(car); } },
            {"Winter Tire", (car) => { return new WinterTire(car); } },
            {"Window Tinting", (car) => { return new WindowTinting(car); } },
        };

        public static BaseCar MakeDecoratorByName(string name,BaseCar car)
        {
            return StrDecoratorMakers[name](car);
        }

        public static String[] DecoratorCarNames()
        {
            string[] keys = new string[StrDecoratorMakers.Count];
            uint i = 0;
            foreach (var item in StrDecoratorMakers) keys[i++] = item.Key;
            return keys;
        }

        /*
        private static CarMaker[] Makers = new CarMaker[]
        {
            () => { return new Mercedes(); },
            () => { return new Volvo(); },
            () => { return new Peugeot(); },
        };

        public static BaseCar MakeCarByIndex(uint index)
        {
            return Makers[index]();
        }
        */

        public override string ToString()
        {
            return about() + " " + string.Format("{0:F2}",price());
        }
    }
    public abstract class DecoratorCar : BaseCar
    {
        protected BaseCar car;
        public DecoratorCar(BaseCar car) { this.car = car; }
    }
    public class Climatization : DecoratorCar
    {
        public Climatization(BaseCar car) : base(car) { }
        protected override string about() { return car.About + " + climatization"; }
        protected override double price() { return car.Price + 300; }
    }
    public class WinterTire : DecoratorCar
    {
        public WinterTire(BaseCar car) : base(car) { }
        protected override string about() { return car.About + " + winter tire"; }
        protected override double price() { return car.Price + 600; }
    }
    public class WindowTinting : DecoratorCar
    {
        public WindowTinting(BaseCar car) : base(car) { }
        protected override string about() { return car.About + " + window tinting"; }
        protected override double price() { return car.Price + 2300; }
    }
    public class Mercedes : BaseCar
    {
        protected override string about() { return "Mercedes"; }
        protected override double price() { return 60000; }
    }
    public class Volvo : BaseCar
    {
        protected override string about() { return "Volvo"; }
        protected override double price() { return 45000; }
    }
    public class Peugeot : BaseCar
    {
        protected override string about() { return "Peugeot"; }
        protected override double price() { return 90000; }
    }
}
