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
        private delegate Car Maker();
        private static Dictionary<string, Maker> map = new Dictionary<string, Maker>()
        {
            {"Mercedes",() => new Mercedes() },
            {"Peugeot",() => new Peugeot() },
            {"Volwo",() => new Volwo() },
            {"Audi",() => new Audi() },
        };
        public static string[] Models { get { return map.Keys.OrderBy((model) => model).ToArray(); } }
        public static Car Make(string model) { return map[model](); }
    }

    public class Mercedes:Car
    {
        public string info() { return "Mercedes"; }
        public int price() { return 90000; }
    }
    public class Volwo : Car
    {
        public string info() { return "Volwo"; }
        public int price() { return 70000; }
    }
    public class Peugeot : Car
    {
        public string info() { return "Peugeot"; }
        public int price() { return 100000; }
    }
    public class Audi : Car
    {
        public string info() { return "Audi"; }
        public int price() { return 80000; }
    }
}
