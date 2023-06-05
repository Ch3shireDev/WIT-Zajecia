using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    delegate Animal AnimalMake(string name);
    public abstract class Animal
    {
        private string name;
        public Animal(string name) { this.name=name; }
        public virtual string path() { return ""; }
        public override string ToString()
        {
            return path()+": "+name;
        }

        private static Dictionary<string, AnimalMake> map = new Dictionary<string, AnimalMake>()
        {
            { "Cow", (string name) => new Cow(name) },
            { "Fly", (string name) => new Fly(name) },
            { "Snake", (string name) => new Snake(name) },

        };

        public static List<string> keys()
        {
            return map.Keys.OrderBy((name) => name).ToList();
        }
        public static Animal make(string kind,string name)
        {
            return map[kind](name);
        }
    }

    public class Mammal:Animal
    {
        public Mammal(string name):base(name) {}
        public override string path() { return base.path()+"/Mammal"; }
    }
    public class Insect:Animal
    {
        public Insect(string name):base(name) {}
        public override string path() { return base.path() + "/Insect"; }
    }
    public class Reptale:Animal
    {
        public Reptale(string name):base(name) { }
        public override string path() { return base.path() + "/Reptale"; }
    }

    public class Cow:Mammal
    {
        public Cow(string name):base(name) { }
        public override string path() { return base.path() + "/Cow"; }
    }
    public class Fly:Insect
    {
        public Fly(string name):base(name) { }
        public override string path() { return base.path() + "/Fly"; }
    }
    public class Snake:Reptale
    {
        public Snake(string name) : base(name) { }
        public override string path() { return base.path() + "/Snake"; }
    }
}
