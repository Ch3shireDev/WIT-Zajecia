import java.util.Arrays;
import java.util.Comparator;
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class AnimalFabric 
{
    private static final HashMap<String,AnimalMaker> map=new HashMap<String,AnimalMaker>()
    {
        {
            //put("Cat",new AnimalMaker(){ public Animal make(String name) { return new Cat(name); } });
            put("Cat",(name)->new Cat(name));
            put("Fly",(name)->new Cat(name));
        }
    };
    public static Animal make(String kind,String name)
    {
        return map.get(kind).make(name);
    }
    //*///
    public static String[] kinds()
    {
        String[] srt=map.keySet().toArray(new String[0]);
        Arrays.sort(srt);
        return srt;
    }
    /*/
    public static List<String> kinds()
    {
        return map.keySet().stream().sorted(Comparator.naturalOrder()).collect(Collectors.toList());
    }
    //*///
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

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    @Override public String path() { return super.path()+"Cat : "; }
}