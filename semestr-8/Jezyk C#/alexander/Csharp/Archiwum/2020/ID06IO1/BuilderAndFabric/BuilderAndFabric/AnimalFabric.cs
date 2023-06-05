using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFabric
{
    delegate Animal AnimalMaker();
    class AnimalFabric
    {
        List<KeyValuePair<string, AnimalMaker>> list = new List<KeyValuePair<string, AnimalMaker>>()
        {
            new KeyValuePair<string, AnimalMaker>("Cat", () => new Cat()),
            new KeyValuePair<string, AnimalMaker>("Fly", () => new Fly()),
        };
        //*///
        private static Dictionary<string, AnimalMaker> map = new Dictionary<string, AnimalMaker>()
        {
            {"Cat", () => new Cat() },
            {"Fly", () => new Fly() },
        };
        /*///
        private static Dictionary<string,AnimalMaker> map=makemap();
        private static Dictionary<string, AnimalMaker> makemap()
        {
            Dictionary<string, AnimalMaker> map = new Dictionary<string, AnimalMaker>();
            map.Add("Cat", () => new Cat());
            map.Add("Fly", () => new Fly());
            return map;
        }
        //*///
        public static List<string> keys()
        {
            List<string> lst = map.Keys.ToList();
            lst.Sort();
            return lst;
        }
        public static Animal make(String kind)
        {
            return map[kind]();
        }
    }
    class Animal
    {

    }

    class Cat : Animal
    {
        public override string ToString()
        {
            return "Puszek";
        }
    }

    class Fly : Animal
    {
        public override string ToString()
        {
            return "Bzzz";
        }
    }
}
