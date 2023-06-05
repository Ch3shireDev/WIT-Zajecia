using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    delegate Car CarMaker();
    abstract class Car
    {
        private static Dictionary<string, CarMaker> map = new Dictionary<string, CarMaker>()
        {
            {"Volvo",() => new Volvo()},
            {"Peugeot",() => new Peugeot()},
            {"Mercedes",() => new Mercedes()},
            {"Skoda",() => new Skoda()},
            {"VolksWagen",() => new VolksWagen()},
        };
        public abstract string info();
        public abstract int price();
        public override string ToString() { return string.Format("{0}\t{1}",price(),info()); }
        public static string[] keys()
        {
            List<string> srt = map.Keys.ToList();
            srt.Sort();
            return srt.ToArray();
        }
        public static Car make(string kind) { return map[kind](); }
    }
    class Volvo : Car
    {
        public override string info() { return "Volvo"; }
        public override int price() { return 20000; }
    }
    class Peugeot : Car
    {
        public override string info() { return "Peugeot"; }
        public override int price() { return 60000; }
    }
    class Mercedes : Car
    {
        public override string info() { return "Mercedes"; }
        public override int price() { return 50000; }
    }
    class Skoda : Car
    {
        public override string info() { return "Skoda"; }
        public override int price() { return 40000; }
    }
    class VolksWagen : Car
    {
        public override string info() { return "VolksWagen"; }
        public override int price() { return 40000; }
    }
}
