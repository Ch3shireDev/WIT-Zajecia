
import java.util.Arrays;
import java.util.HashMap;
import java.util.Set;

public class CarList 
{
   private static final HashMap<String,CarMaker> map=mapmake();
   private static HashMap<String,CarMaker> mapmake()
   {
      final HashMap<String,CarMaker> lmap=new HashMap<>();
      /*
      lmap.put
      (
         "Peugeot", 
         new CarMaker() 
         {
            public @Override Car make() 
            {
               return new Peugeot();
            }
         }
      );
      */
      lmap.put("Peugeot", () -> { return new Peugeot(); } );
      lmap.put("Volvo", () -> { return new Volvo(); } );
      lmap.put("Mercedes", () -> { return new Mercedes(); } );
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
   public static Car make(String key)
   {
      return map.get(key).make();
   }
}
