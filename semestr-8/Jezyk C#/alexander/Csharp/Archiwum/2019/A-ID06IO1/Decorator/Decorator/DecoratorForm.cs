using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace Decorator
{
    public partial class DecoratorForm : Form
    {
        public DecoratorForm()
        {
            InitializeComponent();
            foreach (string name in Car.Fabric.keys) CbCars.Items.Add(name);
            foreach (string name in Car.Decorator.Fabric.keys) ClbDecorators.Items.Add(name);
            CbCars.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = Car.Fabric.make(CbCars.SelectedItem.ToString());
            foreach (string name in ClbDecorators.CheckedItems) car = Car.Decorator.Fabric.make(name, car);
            LbPriceList.Items.Add(car);
        }
    }

    public abstract class Car
    {
        public abstract string info();
        public abstract double price();
        public override string ToString() { return string.Format("{0} {1:F2}", info(), price()); }
        public string selfInfo() { return NameTable.name(this); }
        public double selfPrice() { return PriceTable.price(this); }
        public class Fabric
        {
            public delegate Car CarMaker();
            private static Dictionary<string, CarMaker> map = new Dictionary<string, CarMaker>()
            {
                {"Skoda", () => { return new Skoda(); } },
                {"Peugeot", () => { return new Peugeot(); } },
                {"Volvo", () => { return new Volvo(); } },
            };
            public static List<string> keys { get { return map.Keys.OrderBy((s) => s).ToList(); } }
            //public static List<string> keys { get { List<string> k = map.Keys.ToList(); k.Sort(); return k; } }
            //public static string[] keys { get { string[] tb = map.Keys.ToArray(); Array.Sort(tb); return tb; } }
            public static Car make(string name) { return map[name](); }
        }
        public abstract class Decorator : Car
        {
            protected Car car;
            public Decorator(Car car) { this.car = car; }
            public class Fabric
            {
                public delegate Car CarDecoratorMaker(Car car);
                private static Dictionary<string, CarDecoratorMaker> map = new Dictionary<string, CarDecoratorMaker>()
                {
                    {"Tinted Window", (car) => { return new TintedWindow(car); } },
                    {"Leather Sits", (car) => { return new LeatherSeats(car); } },
                    {"Climatization", (car) => { return new Climatization(car); } },
                    {"Winter Tire", (car) => { return new WinterTire(car); } },
                };
                public static List<string> keys { get { return map.Keys.OrderBy((s) => s).ToList(); } }
                public static Car make(string name, Car car) { return map[name](car); }
            }
        }
    }
    public class TintedWindow : Car.Decorator
    {
        public TintedWindow(Car car) : base(car) {}
        public override string info() { return car.info() + "+ " + selfInfo(); }
        public override double price() { return car.price() + selfPrice(); }
    }
    public class LeatherSeats : Car.Decorator
    {
        public LeatherSeats(Car car) : base(car) { }
        public override string info() { return car.info() + "+ " + selfInfo(); }
        public override double price() { return car.price() + selfPrice(); }
    }
    public class WinterTire : Car.Decorator
    {
        public WinterTire(Car car) : base(car) { }
        public override string info() { return car.info() + "+ " + selfInfo(); }
        public override double price() { return car.price() + selfPrice(); }
    }
    public class Climatization : Car.Decorator
    {
        public Climatization(Car car) : base(car) { }
        public override string info() { return car.info() + "+ " + selfInfo(); }
        public override double price() { return car.price() + selfPrice(); }
    }
    public class Peugeot : Car
    {
        public override string info() { return selfInfo(); }
        public override double price() { return selfPrice();  }
    }
    public class Volvo : Car
    {
        public override string info() { return selfInfo(); }
        public override double price() { return selfPrice(); }
    }
    public class Skoda : Car
    {
        public override string info() { return selfInfo(); }
        public override double price() { return selfPrice(); }
    }
    public class PriceTable
    {
        private static Dictionary<Type, double> map = new Dictionary<Type, double>()
        {
            {typeof(Peugeot), 75000},
            {typeof(Volvo), 45000},
            {typeof(Skoda), 35000},
            {typeof(TintedWindow), 2000},
            {typeof(LeatherSeats), 5000},
            {typeof(WinterTire), 1500},
            {typeof(Climatization), 4000},
        };
        public static double price(Car car) { return map[car.GetType()]; }
    }
    public class NameTable
    {
        private static Dictionary<Type, string> map = new Dictionary<Type, string>()
        {
            {typeof(Peugeot), "Peugeot"},
            {typeof(Volvo), "Volvo"},
            {typeof(Skoda), "Skoda"},
            {typeof(TintedWindow), "Tinted Window"},
            {typeof(LeatherSeats), "Leather Seats"},
            {typeof(WinterTire), "Winter Tire"},
            {typeof(Climatization), "Climatization"},
        };
        public static string name(Car car) { return map[car.GetType()]; }
    }
}
