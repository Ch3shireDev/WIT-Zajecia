using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalTestNamespace
{
    delegate Animal AnimalMaker(string name);
    class AnimalFactory
    {
        private static Dictionary<string, AnimalMaker> map = new Dictionary<string, AnimalMaker>()
        {
            {"Cat", (name) => new Cat(name) },
            {"Dog", (name) => new Dog(name) },
            {"Cow", (name) => new Cow(name) },

            {"Snake", (name) => new Snake(name) },
            {"Turtle", (name) => new Turtle(name) },
            {"Lizard", (name) => new Lizard(name) },

            {"Fly", (name) => new Fly(name) },
            {"Spider", (name) => new Spider(name) },
            {"Ladybug", (name) => new Ladybug(name) },
        };
        public static string[] keys()
        {
            List<string> srt = map.Keys.ToList();
            srt.Sort();
            return srt.ToArray();
        }

        public static Animal make(string kind,string name)
        {
            return map[kind](name);
        }
    }
    abstract class Animal
    {
        protected string name;
        public Animal(string name) { this.name = name; }
        public virtual string path() { return ""; }
        public override string ToString() { return path()+name; }
    }
    abstract class Mammal : Animal
    {
        public Mammal(string name) : base(name) { }
        public override string path() { return base.path() + "Mammal : "; }
    }
    abstract class Insect : Animal
    {
        public Insect(string name) : base(name) { }
        public override string path() { return base.path() + "Insect : "; }
    }
    abstract class Reptile : Animal
    {
        public Reptile(string name) : base(name) { }
        public override string path() { return base.path() + "Reptile : "; }
    }
    class Cat : Mammal
    {
        public Cat(string name) : base(name) { }
        public override string path() { return base.path() + "Cat : "; }
    }
    class Dog : Mammal
    {
        public Dog(string name) : base(name) { }
        public override string path() { return base.path() + "Dog : "; }
    }
    class Cow : Mammal
    {
        public Cow(string name) : base(name) { }
        public override string path() { return base.path() + "Cow : "; }
    }
    class Fly : Insect
    {
        public Fly(string name) : base(name) { }
        public override string path() { return base.path() + "Fly : "; }
    }
    class Spider : Insect
    {
        public Spider(string name) : base(name) { }
        public override string path() { return base.path() + "Spider : "; }
    }
    class Ladybug : Insect
    {
        public Ladybug(string name) : base(name) { }
        public override string path() { return base.path() + "Ladybug : "; }
    }
    class Snake : Reptile
    {
        public Snake(string name) : base(name) { }
        public override string path() { return base.path() + "Snake : "; }
    }
    class Turtle : Reptile
    {
        public Turtle(string name) : base(name) { }
        public override string path() { return base.path() + "Turtle : "; }
    }
    class Lizard : Reptile
    {
        public Lizard(string name) : base(name) { }
        public override string path() { return base.path() + "Lizard : "; }
    }
}
