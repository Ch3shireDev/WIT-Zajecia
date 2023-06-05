using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class CarFactory
    {
        private delegate Car CarMaker();
        private static readonly Dictionary<string, CarMaker> map = new Dictionary<string, CarMaker>()
        {
            {"Audi", () => new Audi() },
            {"Volvo", () => new Volvo() },
            {"Toyota", () => new Toyota() },
            {"Seat", () => new Seat() },
        };
    }
}
