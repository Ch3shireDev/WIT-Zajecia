using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
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
            {"Dog",(name) => new Dog(name)},
            {"Fly",(name) => new Fly(name)},
            {"Turtle",(name) => new Turtle(name)},
        };
        public static Animal make(string kind,string name)
        {
            return map[kind](name);
        }
        public static List<string> kinds()
        {
            return map.Keys.OrderBy((kind) => kind).ToList();
        }
    }
    class Mammal:Animal
    {
        public Mammal(string name):base(name) {}
        public override string path() { return base.path()+"/Mammal"; }
    }
    class Reptile:Animal
    {
        public Reptile(string name):base(name) { }
        public override string path() { return base.path()+"/Reptile"; }
    }
    class Insect:Animal
    {
        public Insect(string name):base(name) { }
        public override string path() { return base.path()+"/Insect"; }
    }
    class Cat:Mammal
    {
        public Cat(string name):base(name) {}
        public override string path() { return base.path()+"/Cat"; }
    }
    class Dog:Mammal
    {
        public Dog(string name):base(name) {}
        public override string path() { return base.path()+"/Dog"; }
    }
    class Turtle:Reptile
    {
        public Turtle(string name):base(name) {}
        public override string path() { return base.path()+"/Turtle"; }
    }
    class Fly:Insect
    {
        public Fly(string name):base(name) {}
        public override string path() { return base.path()+"/Fly"; }
    }
}
