
import java.util.Arrays;
import java.util.Comparator;
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class AnimalFabric 
{
    //*///
    static class MyMap extends HashMap<String,AnimalMaker>
    {
        public MyMap()
        {
            super();
        }
        public MyMap(int x)
        {
            super();
        }
        {
            put("Cat",(name) -> new Cat(name));
            put("Fly",(name) -> new Cat(name));
        }
    }
    private static final MyMap MAP=new MyMap();
    /*/    
    private static final HashMap<String,AnimalMaker> MAP=new HashMap<String,AnimalMaker>()
    {
        {
            //put("Cat",new AnimalMaker(){ public Animal make(String name) {  return new Cat(name); }});
            put("Cat",(name) -> new Cat(name));
            put("Fly",(name) -> new Cat(name));
        }
    };
    //*///
    public static Animal make(String kind,String name)
    {
        return MAP.get(kind).make(name);
    }
    /*///
    public static String[] kinds()
    {
        String[] srt = MAP.keySet().toArray(new String[0]);
        Arrays.sort(srt);
        return srt;
    }
    /*/
    public static List<String> kinds()
    {
        return MAP.keySet().stream().sorted(Comparator.naturalOrder()).collect(Collectors.toList());
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
    @Override public String path() { return super.path() + "Mammal : "; }
}

class Cat extends Mammal
{
    public Cat(String name) { super(name); }
    @Override public String path() { return super.path() + "Cat : "; }
}