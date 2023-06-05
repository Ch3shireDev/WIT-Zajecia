using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    abstract class CarFactory 
    {
        private delegate Car maker();
        private static readonly Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"Volvo",() => new Volvo() },
            {"Seat",() => new Seat() },
            {"Toyota",() => new Toyota() },
            {"Audi",() => new Audi() },
        };
        public static readonly string[] Models = map.Keys.OrderBy(m => m).ToArray();
        public static Car make(string model) { return map[model](); }
    }
}
