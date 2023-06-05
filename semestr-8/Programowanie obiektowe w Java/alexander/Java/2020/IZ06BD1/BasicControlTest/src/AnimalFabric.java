
import java.util.Arrays;
import java.util.HashMap;

public class AnimalFabric 
{
    private static final HashMap<String,AnimalMaker> kinds=new HashMap<String,AnimalMaker>()
    {
        {
            put("Cat",(name)->new Cat(name));
            put("Snake",(name)->new Snake(name));
            put("Fly",(name)->new Fly(name));
            
        }
    };
    public static String[] keys()
    {
        String[] srt=kinds.keySet().toArray(new String[0]);
        Arrays.sort(srt);
        return srt;
    }
    public static Animal make(String kind,String name)
    {
        AnimalMaker am=kinds.get(kind);
        return am!=null?am.make(name):null;
    }
}

interface AnimalMaker
{
    Animal make(String name);
}

class Animal
{
    private String name;
    public Animal(String name) { this.name=name; }
    public String path() { return ""; }
    @Override public String toString() { return path() + name; }
}

class Mammal extends Animal
{
    public Mammal(String name) { super(name); }
    @Override public String path() { return super.path()+"Mammal : "; }
}

class Insect extends Animal
{
    public Insect(String name) { super(name); }
    @Override public String path() { return super.path()+"Insect : "; }
}

class Reptile extends Animal
{
    public Reptile(String name) { super(name); }
    @Override public String path() { return super.path()+"Reptile : "; }
}

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    @Override public String path() { return super.path()+"Cat : "; }
}

class Fly extends Insect
{
    public Fly(String name) { super(name); }
    @Override public String path() { return super.path()+"Fly : "; }
}

class Snake extends Reptile
{
    public Snake(String name) { super(name); }
    @Override public String path() { return super.path()+"Snake : "; }
}
