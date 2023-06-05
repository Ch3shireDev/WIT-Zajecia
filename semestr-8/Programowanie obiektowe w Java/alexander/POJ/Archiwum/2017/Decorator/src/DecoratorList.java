import java.util.HashMap;
import java.util.Set;

public class DecoratorList 
{
   private static HashMap<String,DecaratorMaker> map=makemap();
   private static HashMap<String,DecaratorMaker> makemap()
   {
      HashMap<String,DecaratorMaker> map=new HashMap<>();
      map.put
      (
         "Climatization",
         new DecaratorMaker() { @Override public BaseCar make(BaseCar car) { return new Climatization(car); } }
      );
      map.put("Winter Tire", (DecaratorMaker) (BaseCar car) -> new WinterTire(car));
      map.put("Tinting Window", (DecaratorMaker) (BaseCar car) -> new TintingWindow(car));
      return map;
   }
   public static BaseCar makeByName(String name,BaseCar car)
   {
      return map.get(name).make(car);
   }
   public static Set<String> names()
   {
      return map.keySet();
   }   
}
