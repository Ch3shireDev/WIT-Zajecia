package Animals;


import Animals.Mammal.Cow;
import Animals.Mammal.Cat;
import Animals.Mammal.Dog;
import Animals.Insect.Ladybug;
import Animals.Insect.Spider;
import Animals.Insect.Fly;
import Animals.Reptile.Lizard;
import Animals.Reptile.Turtle;
import Animals.Reptile.Snake;
import java.util.Arrays;
import java.util.Comparator;
import java.util.HashMap;
import java.util.List;
import java.util.Set;
import java.util.stream.Collectors;

public class AnimalFactory 
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
            
            put("Snake",(name)->new Snake(name));
            put("Turtle",(name)->new Turtle(name));
            put("Lizard",(name)->new Lizard(name));
        }        
    };
    public static Animal make(String kind,String name)
    {
        return map.get(kind).make(name);
    }
    //*/// Wersja A
    public static String[] keys()
    {
        final Set<String> set=map.keySet();
        final String[] list=set.toArray(new String[0]);
        Arrays.sort(list);
        return list; // funkcja zwraca String[]
    }
    /*/// Wersja B
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
    //*/// Koniec alternatyw
}

interface AnimalMaker
{
    Animal make(String name);
}
