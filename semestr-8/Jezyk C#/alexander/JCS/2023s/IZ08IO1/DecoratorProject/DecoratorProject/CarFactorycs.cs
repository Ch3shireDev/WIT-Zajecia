using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    abstract class CarFactorycs
    {
        private delegate Car maker();
        private static readonly Dictionary<string, maker> map = new Dictionary<string, maker>()
        {
            {"Volvo",  () => new Volvo()  },
            {"Audi",   () => new Audi()   },
            {"Toyota", () => new Toyota() },
            {"Seat",   () => new Seat()   },
        };
        public static readonly string[] Models = map.Keys.OrderBy(m => m).ToArray();
        public static Car make(string model)
        {
            return map[model]();
        }
    }
}
