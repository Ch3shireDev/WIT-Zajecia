
import java.util.List;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.HashMap;
import java.util.stream.Collectors;

public class AnimalFabric
{
    private static final HashMap<String,AnimalMaker> kinds=new HashMap<String,AnimalMaker>()
    {
        {             //new AnimalMaker() { @Override public Animal make(String name) { return new Cat(name); } } 
            put("Cat",(name) -> new Cat(name));
            put("Dog",(name) -> new Dog(name));
            put("Cow",(name) -> new Cow(name));
            put("Fly",(name) -> new Fly(name));
            put("Spider",(name) -> new Spider(name));
            put("Ladybug",(name) -> new Ladybug(name));
            put("Snake",(name) -> new Snake(name));
            put("Lizard",(name) -> new Lizard(name));
            put("Turtle",(name) -> new Turtle(name));
        }
    };
    //*///
    public static List<String> keys() 
    {
        return kinds.keySet().stream().sorted(Comparator.naturalOrder()).collect(Collectors.toList());
    }
    /*/
    public static String[] keys() 
    {
        String[] srt=kinds.keySet().toArray(new String[0]);
        Arrays.sort(srt);        
        return srt;
    }
    //*///
    public static Animal make(String kind,String name)
    {
        return kinds.get(kind).make(name);
        /*
        switch(kind)
        {
            case "Cat": return new Cat(name);
            case "Dog": return new Dog(name);
            case "Cow": return new Cow(name);
            case "Fly": return new Fly(name);
            case "Spider": return new Spider(name);
            case "Ladybug": return new Ladybug(name);            
            case "Snake": return new Snake(name);
            case "Lizard": return new Lizard(name);
            case "Turtle": return new Turtle(name);
        }
        return null;
        */
    }
}       

interface AnimalMaker
{
    Animal make(String name);
}

class Animal 
{
    private String name;
    public Animal(String name) { this.name = name; }
    public String path() { return ""; }
    @Override public String toString() { return path() + name; }    
}

class Mammal extends Animal 
{
    public Mammal(String name) { super(name); }
    @Override public String path() { return super.path() + "Mammal : "; }
}

class Insect extends Animal 
{
    public Insect(String name) { super(name); }
    @Override public String path() { return super.path() + "Insect : "; }
}

class Reptile extends Animal 
{
    public Reptile(String name) { super(name); }
    @Override public String path() { return super.path() + "Reptile : "; }
}

class Cat extends Mammal 
{
    public Cat(String name) { super(name); }
    @Override public String path() { return super.path() + "Cat : "; }
}

class Dog extends Mammal 
{
    public Dog(String name) { super(name); }
    @Override public String path() { return super.path() + "Dog : "; }
}

class Cow extends Mammal 
{
    public Cow(String name) { super(name); }
    @Override public String path() { return super.path() + "Cow : "; }
}

class Fly extends Insect
{
    public Fly(String name) { super(name); }
    @Override public String path() { return super.path() + "Fly : "; }
}

class Spider extends Insect
{
    public Spider(String name) { super(name); }
    @Override public String path() { return super.path() + "Spider : "; }
}

class Ladybug extends Insect
{
    public Ladybug(String name) { super(name); }
    @Override public String path() { return super.path() + "Ladybug : "; }
}

class Snake extends Reptile
{
    public Snake(String name) { super(name); }
    @Override public String path() { return super.path() + "Snake : "; }
}

class Lizard extends Reptile
{
    public Lizard(String name) { super(name); }
    @Override public String path() { return super.path() + "Lizard : "; }
}

class Turtle extends Reptile
{
    public Turtle(String name) { super(name); }
    @Override public String path() { return super.path() + "Turtle : "; }
}

