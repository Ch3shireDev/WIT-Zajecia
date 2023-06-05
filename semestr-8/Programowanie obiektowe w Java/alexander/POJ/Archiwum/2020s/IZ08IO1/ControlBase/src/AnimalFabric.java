import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;

public class AnimalFabric 
{
    private final static HashMap<String,AnimalMaker> map=new HashMap<String,AnimalMaker>()
    {
        {
            put("Cat",(name)->new Cat(name));
            put("Dog",(name)->new Dog(name));
            put("Cow",(name)->new Cow(name));
            
            put("Fly",(name)->new Fly(name));
            put("Dragonfly",(name)->new Dragonfly(name));
            put("Ladybug",(name)->new Ladybug(name));

            put("Crocodile",(name)->new Crocodile(name));
            put("Turtle",(name)->new Turtle(name));
            put("Frog",(name)->new Frog(name));
        }
    };
    public static Animal make(String type,String name)
    {
        return map.get(type).make(name);
    }
    public static String[] keys()
    {
        String[] srt=new String[map.size()];
        map.keySet().toArray(srt);
        Arrays.sort(srt);
        return srt;
    }
}

interface AnimalMaker
{
    Animal make(String name);
}

abstract class Animal
{
    private final String name;
    public Animal(String name) { this.name=name; }
    public String path() { return ""; }
    @Override public String toString() { return path()+name; }
}

abstract class Mammal extends Animal
{
    public Mammal(String name) { super(name); }
    @Override public String path() { return super.path()+"Mammal : "; }
}

abstract class Insect extends Animal
{
    public Insect(String name) { super(name); }
    @Override public String path() { return super.path()+"Insect : "; }
}

abstract class Reptilie extends Animal
{
    public Reptilie(String name) { super(name); }
    @Override public String path() { return super.path()+"Reptilie : "; }
}

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    @Override public String path() { return super.path()+"Cat : "; }
}

class Dog extends Mammal
{
    public Dog(String name) { super(name); }
    @Override public String path() { return super.path()+"Dog : "; }
}

class Cow extends Mammal
{
    public Cow(String name) { super(name); }
    @Override public String path() { return super.path()+"Cow : "; }
}

class Fly extends Insect
{
    public Fly(String name) { super(name); }
    @Override public String path() { return super.path()+"Fly : "; }
}

class Dragonfly extends Insect
{
    public Dragonfly(String name) { super(name); }
    @Override public String path() { return super.path()+"Dragonfly : "; }
}

class Ladybug extends Insect
{
    public Ladybug(String name) { super(name); }
    @Override public String path() { return super.path()+"Ladybug : "; }
}

class Crocodile extends Reptilie
{
    public Crocodile(String name) { super(name); }
    @Override public String path() { return super.path()+"Crocodile : "; }
}

class Turtle extends Reptilie
{
    public Turtle(String name) { super(name); }
    @Override public String path() { return super.path()+"Turtle : "; }
}

class Frog extends Reptilie
{
    public Frog(String name) { super(name); }
    @Override public String path() { return super.path()+"Frog : "; }
}
