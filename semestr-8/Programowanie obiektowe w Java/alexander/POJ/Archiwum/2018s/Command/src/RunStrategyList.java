
import java.util.HashMap;

public class RunStrategyList 
{
   private static final HashMap<String,RunStrategy> map=makemap();
   private static final HashMap<String,RunStrategy> makemap()
   {
      final HashMap<String,RunStrategy> tmp=new HashMap<>();
      tmp.put("Maraton", new Maraton());
      tmp.put("Sprint", new Sprint());
      tmp.put("MedDistance", new MedDistance());
      return tmp;
   }
   public static Object[] names()
   {
      return map.keySet().toArray();
   }
   public static RunStrategy byName(String name)
   {
      return map.get(name);
   }
}
