
import java.util.HashMap;

public class JumpStrategyList 
{
   private static final HashMap<String,JumpStrategy> map=makemap();
   private static final HashMap<String,JumpStrategy> makemap()
   {
      final HashMap<String,JumpStrategy> tmp=new HashMap<>();
      tmp.put("HighJump", new HighJump());
      tmp.put("LongJump", new LongJump());
      tmp.put("RailingsJump", new RailingsJump());
      return tmp;
   }
   public static Object[] names()
   {
      return map.keySet().toArray();
   }
   public static JumpStrategy byName(String name)
   {
      return map.get(name);
   }
}
