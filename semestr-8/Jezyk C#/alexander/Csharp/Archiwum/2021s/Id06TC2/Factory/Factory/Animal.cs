using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    delegate Animal AnimalMaker(string Name);
    public class AnimalFactory
    {
        private static Dictionary<string,AnimalMaker> map=new Dictionary<string,AnimalMaker>()
        {
            {"Cow", (string Name) => new Cow(Name) },
            {"Cat", (string Name) => new Cat(Name) },
            {"Dog", (string Name) => new Dog(Name) },
            {"Fly", (string Name) => new Fly(Name) },
        };

        public static Animal make(string kind,string name)
        {
            return map[kind](name);
        }
        public static List<string> keys()
        {
            return map.Keys.OrderBy((kind) => kind).ToList();
        }
    }
    public abstract class Animal
    {
        private string name;
        public Animal(string name) { this.name=name; }
        public override string ToString() { return Path()+" : "+name; }
        public virtual string Path() { return ""; }
    }

    public class Mammal : Animal 
    {
        public Mammal(string name):base(name) {}
        public override string Path() { return base.Path()+"/Mammal"; }
    }
    public class Cow : Mammal
    {
        public Cow(string name):base(name) { }
        public override string Path() { return base.Path() + "/Cow"; }
    }
    public class Cat : Mammal
    {
        public Cat(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Cat"; }
    }
    public class Dog : Mammal
    {
        public Dog(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Dog"; }
    }
    public class Insect : Animal
    {
        public Insect(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Insect"; }
    }
    public class Fly : Insect
    {
        public Fly(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Fly"; }
    }
    public class Dragonfly : Insect
    {
        public Dragonfly(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Dragonfly"; }
    }
    public class Bee : Insect
    {
        public Bee(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Bee"; }
    }
    public class Reptyle : Animal
    {
        public Reptyle(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Reptyle"; }
    }
    public class  Turtle : Reptyle
    {
        public Turtle(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Turtle"; }
    }
    public class Crocodyle : Reptyle
    {
        public Crocodyle(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Crocodyle"; }
    }
    public class Snake : Reptyle
    {
        public Snake(string name) : base(name) { }
        public override string Path() { return base.Path() + "/Snake"; }
    }
}
