
import java.awt.Color;
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class ColorFactory
{
   private static final HashMap<String,Color> map=new HashMap<String,Color>()
   {
      {
         put("Czerwony",Color.RED);
         put("Zielony",Color.GREEN);
         put("Niebieski",Color.BLUE);
         put("Żółty",Color.YELLOW);
      }
   };
   private static final List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
   public static List<String> getKeys() { return keys; }
   public static Color make(String name) { return map.get(name); }
}
