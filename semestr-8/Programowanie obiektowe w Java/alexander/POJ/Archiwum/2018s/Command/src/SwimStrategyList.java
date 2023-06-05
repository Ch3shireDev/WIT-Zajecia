
import java.util.HashMap;

public class SwimStrategyList 
{
   private static final HashMap<String,SwimStrategy> map=makemap();
   private static final HashMap<String,SwimStrategy> makemap()
   {
      final HashMap<String,SwimStrategy> tmp=new HashMap<>();
      tmp.put("Crawl", new Crawl());
      tmp.put("Butterfly", new Butterfly());
      tmp.put("Frog", new Frog());
      return tmp;
   }
   public static Object[] names()
   {
      return map.keySet().toArray();
   }
   public static SwimStrategy byName(String name)
   {
      return map.get(name);
   }
}
