using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    abstract class CarDecoratorFactory
    {
        private delegate Car maker(Car car);
        private static readonly Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"AirCondition",(car) => new AirCondition(car) },
            {"TintedWindow",(car) => new TintedWindow(car) },
            {"WinterTire",(car) => new WinterTire(car) },
            {"LeatherSeats",(car) => new LeatherSeats(car) },
        };
        public static readonly string[] Decorators = map.Keys.OrderBy(d => d).ToArray();
        public static Car make(string decorator, Car car) { return map[decorator](car); }
    }
}
