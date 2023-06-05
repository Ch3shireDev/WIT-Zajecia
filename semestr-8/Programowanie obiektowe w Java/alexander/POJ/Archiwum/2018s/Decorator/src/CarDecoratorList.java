
import java.util.Arrays;
import java.util.HashMap;
import java.util.Set;

public class CarDecoratorList 
{
   private static final HashMap<String,CarDecoratorMaker> map=mapmake();
   private static HashMap<String,CarDecoratorMaker> mapmake()
   {
      final HashMap<String,CarDecoratorMaker> lmap=new HashMap<>();
      lmap.put("Tonowane szyby", (Car car) -> { return new TintedWindow(car); } );
      lmap.put("Klimatyzacja", (Car car) -> { return new AirCondition(car); } );
      lmap.put("Opony zimowe", (Car car) -> { return new WinterTire(car); } );
      lmap.put("Skórzana tapicerka", (Car car) -> { return new LeatherSeats(car); } );
      return lmap;
   }
   public static String[] names()
   {
      final Set<String> lst=map.keySet();
      String[] keys=new String[lst.size()];
      keys=lst.toArray(keys);
      Arrays.sort(keys);
      return keys;
   }
   public static Car make(String key,Car car)
   {
      return map.get(key).make(car);
   }
}
