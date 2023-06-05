using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface Car
    {
        int price();
        string info();
        int tintedWindowPrice();
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
        public static List<string> Models { get { return map.Keys.OrderBy((model) => model).ToList(); } }
        public static Car Make(string model) { return map[model](); }
        //public static Car this[string model] { get { return map[model](); } }
    }
    public class Mercedes : Car 
    {
        public int price() { return 70000; }
        public string info() { return "Mercedes"; }
        public int tintedWindowPrice() { return 3000; }
    }
    public class Audi : Car
    {
        public int price() { return 50000; }
        public string info() { return "Audi"; }
        public int tintedWindowPrice() { return 3200; }
    }
    public class Volvo : Car
    {
        public int price() { return 60000; }
        public string info() { return "Volvo"; }
        public int tintedWindowPrice() { return 3400; }
    }
    public class Peugeot : Car
    {
        public int price() { return 90000; }
        public string info() { return "Peugeot"; }
        public int tintedWindowPrice() { return 3600; }
    }
}
