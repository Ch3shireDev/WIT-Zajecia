
import java.util.List;
import java.util.HashMap;
import java.util.stream.Collectors;

public class AnimalFabric
{
   private static final HashMap<String,AnimalMaker> map=makemap();
   private static HashMap<String,AnimalMaker> makemap()
   {
      final HashMap<String,AnimalMaker> map=new HashMap<String,AnimalMaker>();
      map.put("Cat",(name) -> new Cat(name));
      map.put("Dog",(name) -> new Dog(name));
      map.put("Fly",(name) -> new Fly(name));
      return map;
   }
   public static Animal make(String kind,String name)
   {
      return map.get(kind).make(name);
   }
   public static List<String> keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
}
