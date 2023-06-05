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
    public delegate Car CarMaker();
    public delegate Car CarDecoratorMaker(Car car);

    public partial class DecoratorForm : Form
    {
        public DecoratorForm()
        {
            InitializeComponent();
            foreach (string name in Car.Fabric.keys) CbCars.Items.Add(name);
            foreach (string name in CarDecorator.Fabric.keys) ClbDecorators.Items.Add(name);
            CbCars.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = Car.Fabric.make(CbCars.SelectedItem.ToString());
            foreach (string name in ClbDecorators.CheckedItems) car = CarDecorator.Fabric.make(name, car);
            LbPriceList.Items.Add(car);
        }
    }

    public abstract class Car
    {
        public abstract string info();
        public abstract double price();
        public override string ToString() { return string.Format("{0} {1:F2}", info(), price()); }
        public class Fabric
        {
            private static SortedDictionary<string, CarMaker> map = new SortedDictionary<string, CarMaker>()
            {
                {"Skoda", () => { return new Skoda(); } },
                {"Peugeot", () => { return new Peugeot(); } },
                {"Volvo", () => { return new Volvo(); } },
            };
            public static SortedDictionary<string, CarMaker>.KeyCollection keys { get { return map.Keys; } }
            public static Car make(string name) { return map[name](); }
        }
    }
    public abstract class CarDecorator: Car
    {
        protected Car car;
        public CarDecorator(Car car) { this.car = car; }
        public class Fabric
        {
            private static SortedDictionary<string, CarDecoratorMaker> map = new SortedDictionary<string, CarDecoratorMaker>()
            {
                {"Tinted Window", (car) => { return new TintedWindow(car); } },
                {"Leather Sits", (car) => { return new LeatherSits(car); } },
                {"Climatization", (car) => { return new Climatization(car); } },
                {"Winter Tire", (car) => { return new WinterTire(car); } },
            };
            public static SortedDictionary<string, CarDecoratorMaker>.KeyCollection keys { get { return map.Keys; } }
            public static Car make(string name, Car car) { return map[name](car); }
        }
    }
    public class TintedWindow : CarDecorator
    {
        public TintedWindow(Car car) : base(car) {}
        public override string info() { return car.info() + "+ Tinted Window"; }
        public override double price() { return car.price() + PriceTable.price(GetType().Name); }
    }
    public class LeatherSits : CarDecorator
    {
        public LeatherSits(Car car) : base(car) { }
        public override string info() { return car.info() + "+ Leather Sits"; }
        public override double price() { return car.price() + PriceTable.price(GetType().Name); }
    }
    public class WinterTire : CarDecorator
    {
        public WinterTire(Car car) : base(car) { }
        public override string info() { return car.info() + "+ Winter Tire"; }
        public override double price() { return car.price() + PriceTable.price(GetType().Name); }
    }
    public class Climatization : CarDecorator
    {
        public Climatization(Car car) : base(car) { }
        public override string info() { return car.info() + "+ Climatization"; }
        public override double price() { return car.price() + PriceTable.price(GetType().Name); }
    }
    public class Peugeot : Car
    {
        public override string info() { return "Peugeot"; }
        public override double price() { return PriceTable.price(GetType().Name);  }
    }
    public class Volvo : Car
    {
        public override string info() { return "Volvo"; }
        public override double price() { return PriceTable.price(GetType().Name); }
    }
    public class Skoda : Car
    {
        public override string info() { return "Skoda"; }
        public override double price() { return PriceTable.price(GetType().Name); }
    }
    public class PriceTable
    {
        private static Dictionary<string, double> map = new Dictionary<string, double>()
        {
            {typeof(Peugeot).Name, 75000},
            {typeof(Volvo).Name, 45000},
            {typeof(Skoda).Name, 35000},
            {typeof(TintedWindow).Name, 2000},
            {typeof(LeatherSits).Name, 5000},
            {typeof(WinterTire).Name, 1500},
            {typeof(Climatization).Name, 4000},
        };
        public static double price(string name) { return map[name]; }
    }
}
