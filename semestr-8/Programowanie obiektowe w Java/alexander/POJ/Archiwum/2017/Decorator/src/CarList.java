import java.util.HashMap;
import java.util.Set;

public class CarList 
{
   private static HashMap<String,CarMaker> map=makemap();
   private static HashMap<String,CarMaker> makemap()
   {
      HashMap<String,CarMaker> map=new HashMap<>();
      map.put
      (
         "Mercedes",
         new CarMaker() { @Override public BaseCar make() { return new Mercedes(); } }
      );
      map.put("Peugeot", (CarMaker) () -> new Peugeot());
      map.put("Volvo", (CarMaker) () -> new Volvo());
      return map;
   }
   public static BaseCar makeByName(String name)
   {
      return map.get(name).make();
   }
   public static Set<String> names()
   {
      return map.keySet();
   }   
}
