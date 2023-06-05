
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class AnimalFactory
{
   private static HashMap<String,AnimalMaker> map=makemap();
   private static HashMap<String,AnimalMaker> makemap()
   {
      HashMap<String,AnimalMaker> map=new HashMap<String,AnimalMaker>();
      /*
      map.put
      (
         "Dog",
         new AnimalMaker()
         {
            public Animal make(String name)
            {
               return new Dog(name);
            }
         }
      );
      */
      map.put("Dog",(name) -> new Dog(name));
      map.put("Cat",(name) -> new Cat(name));
      return map;
   };
   public static Animal make(String kind,String name) { return map.get(kind).make(name); }
   public static List<String> keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
}
