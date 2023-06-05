using System.Collections.Generic;

namespace PointTest
{
    delegate Animal MakeAnimal(string name);
    class AnimalFabric
    {
        private static Dictionary<string, MakeAnimal> map = makemap();
        private static Dictionary<string, MakeAnimal> makemap()
        {
            Dictionary<string, MakeAnimal> map = new Dictionary<string, MakeAnimal>();
            map.Add("Cat", (name) => new Cat(name));
            map.Add("Dog", (name) => new Dog(name));
            map.Add("Cow", (name) => new Cow(name));
            map.Add("Fly", (name) => new Fly(name));
            map.Add("Spider", (name) => new Spider(name));
            map.Add("Ladybug", (name) => new Ladybug(name));
            map.Add("Crocodile", (name) => new Crocodile(name));
            map.Add("Turtle", (name) => new Turtle(name));
            map.Add("Snake", (name) => new Snake(name));
            return map;
        }

        public static List<string> keys()
        {
            List<string> srt = new List<string>();
            srt.AddRange(map.Keys);
            srt.Sort();
            return srt;
        }

        public static Animal make(string kind, string name)
        {
            return map[kind](name);
        }
    }
    abstract class Animal
    {
        public string name { get;  set; }
        public Animal(string name) { this.name = name; }
        public virtual string path() { return ""; }
        public override string ToString() { return path() + name; }
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
    class Ladybug : Insect
    {
        public Ladybug(string name) : base(name) { }
        public override string path() { return base.path() + "Ladybug : "; }
    }
    class Spider : Insect
    {
        public Spider(string name) : base(name) { }
        public override string path() { return base.path() + "Spider : "; }
    }
    class Turtle : Reptile
    {
        public Turtle(string name) : base(name) { }
        public override string path() { return base.path() + "Turtle : "; }
    }
    class Crocodile : Reptile
    {
        public Crocodile(string name) : base(name) { }
        public override string path() { return base.path() + "Crocodile : "; }
    }
    class Snake : Reptile
    {
        public Snake(string name) : base(name) { }
        public override string path() { return base.path() + "Snake : "; }
    }
}
