import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class CarFabric 
{
   private final static HashMap<String,CarMaker> map=new HashMap<String, CarMaker>()
   {
      {
         put("Mercedes",() -> new Mercedes());
         put("Peugeot",() -> new Peugeot());
         put("Szkoda",() -> new Szkoda());
      }
   };
   public static Car make(String kind)
   {
      return map.get(kind).make();
   }
   public static List<String> keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
}


