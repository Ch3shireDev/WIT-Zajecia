
import java.util.Comparator;
import java.util.HashMap;
import java.util.List;
import java.util.Objects;
import java.util.Set;
import java.util.stream.Collectors;

public class AnimalFabric 
{
    private static final HashMap<String,AnimalMaker> map=new HashMap<String,AnimalMaker>()
    {
        {
            put("Cat",(name)->new Cat(name));
            put("Dog",(name)->new Dog(name));
            put("Cow",(name)->new Cow(name));

            put("Fly",(name)->new Fly(name));
            put("Spider",(name)->new Spider(name));
            put("Ladybug",(name)->new Ladybug(name));

            put("Crocodile",(name)->new Crocodile(name));
            put("Frog",(name)->new Frog(name));
            put("Turtle",(name)->new Turtle(name));
        }
    };
    public static Animal make(String kind,String name)
    {
        return map.get(kind).make(name);
    }
//*///
    public static List<String> keys()
    {
        return 
            map
            .keySet()
            .stream()
            .sorted(Comparator.naturalOrder())
            .collect(Collectors.toList())
        ;
    }
/*/
    public static String[] keys()
    {
        Set<String> srt=map.keySet();
        String[] tb=new String[map.size()];
        srt.toArray(tb);
        Arrays.sort(tb);
        return tb;
    }
//*///
}

interface AnimalMaker
{
    Animal make(String name);
}

abstract class Animal
{
    private final String name;
    public Animal(String name) { this.name=name; }
    protected String path() { return ""; }
    @Override public String toString() { return path()+name; }
}

abstract class Mammal extends Animal
{
    public Mammal(String name) { super(name); }
    @Override protected String path() { return super.path()+"Mammal : "; }
}

abstract class Reptile extends Animal
{
    public Reptile(String name) { super(name); }
    @Override protected String path() { return super.path()+"Reptile : "; }
}

abstract class Insect extends Animal
{
    public Insect(String name) { super(name); }
    @Override protected String path() { return super.path()+"Insect : "; }
}

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    @Override public String toString() { return super.path()+"Cat : "; }
}

class Dog extends Mammal
{
    public Dog(String name) { super(name); }
    @Override public String toString() { return super.path()+"Dog : "; }
}

class Cow extends Mammal
{
    public Cow(String name) { super(name); }
    @Override public String toString() { return super.path()+"Cow : "; }
}

class Fly extends Insect
{
    public Fly(String name) { super(name); }
    @Override public String toString() { return super.path()+"Fly : "; }
}

class Ladybug extends Insect
{
    public Ladybug(String name) { super(name); }
    @Override public String toString() { return super.path()+"Ladybug : "; }
}

class Spider extends Insect
{
    public Spider(String name) { super(name); }
    @Override public String toString() { return super.path()+"Spider : "; }
}

class Crocodile extends Reptile
{
    public Crocodile(String name) { super(name); }
    @Override public String toString() { return super.path()+"Crocodile : "; }
}

class Turtle extends Reptile
{
    public Turtle(String name) { super(name); }
    @Override public String toString() { return super.path()+"Turtle : "; }
}

class Frog extends Reptile
{
    public Frog(String name) { super(name); }
    @Override public String toString() { return super.path()+"Frog : "; }
}
