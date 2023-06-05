using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    delegate Animal AnimalMaker(string name);
    public abstract class Animal
    {
        private string name;
        public Animal(string name) { this.name=name; }
        public virtual string path() { return ""; }
        public override string ToString() { return path()+": "+name; }

        private static Dictionary<string, AnimalMaker> map = new Dictionary<string, AnimalMaker>()
        {
            {"Cat",(name) => new Cat(name)},
            {"Fly",(name) => new Fly(name)},
            {"Crocodyle",(name) => new Crocodyle(name)},
        };

        public static Animal make(string kind,string name)
        {
            return map[kind](name);
        }
        public static List<string> kinds
        {
            get { return map.Keys.OrderBy((kind) => kind).ToList(); }
        }
    }

    public abstract class Mammal:Animal
    {
        public Mammal(string name):base(name) { }
        public override string path() { return base.path() + "/Mammal"; }
    }
    public abstract class Reptile:Animal
    {
        public Reptile(string name):base(name) {}
        public override string path() { return base.path()+"/Reptile"; }
    }
    public abstract class Insect:Animal
    {
        public Insect(string name):base(name) {}
        public override string path() { return base.path()+"/Insect"; }
    }

    public class Cat:Mammal
    {
        public Cat(string name):base(name) { }
        public override string path() { return base.path()+"/Cat"; }
    }
    public class Fly:Insect
    {
        public Fly(string name):base(name) { }
        public override string path() { return base.path()+"/Fly"; }
    }
    public class Crocodyle:Reptile
    {
        public Crocodyle(string name):base(name) { }
        public override string path() { return base.path()+"/Crocodyle"; }
    }
}
