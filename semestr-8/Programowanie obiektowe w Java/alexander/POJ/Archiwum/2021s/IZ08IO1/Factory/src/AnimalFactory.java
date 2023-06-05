
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class AnimalFactory
{
   private static HashMap<String,AnimalMaker> map=new HashMap<String,AnimalMaker>()
   {
      {
         put("Cow",(name) -> new Cow(name));
         put("Dog",(name) -> new Dog(name));
         put("Cat",(name) -> new Cat(name));
         put("Fly",(name) -> new Fly(name));
      }
   };

   public static List<String> kinds()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }

   public static Animal make(String kind,String name)
   {
      return map.get(kind).make(name);
   }
}

interface AnimalMaker
{
   public Animal make(String name);
}