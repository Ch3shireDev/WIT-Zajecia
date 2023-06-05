using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFabric
{
    delegate Animal MakeAnimal();
    class AnimalFabric
    {
        private static Dictionary<string, MakeAnimal> map = MakeMap();
        private static Dictionary<string, MakeAnimal> MakeMap()
        {
            Dictionary<string, MakeAnimal> map = new Dictionary<string, MakeAnimal>();
            map.Add("Cat", () => new Cat());
            map.Add("Fly", () => new Fly());
            return map;
        }
        private static Animal mk() { return new Cat(); }
        public static Animal make(string kind) { return map[kind](); }
        public static List<string> keys()
        {
            List<string> lst = map.Keys.ToList();
            lst.Sort();
            return lst;
        }
    };


    class Animal
    {

    }
    class Cat : Animal
    {

    }
    class Fly : Animal
    {

    }
}