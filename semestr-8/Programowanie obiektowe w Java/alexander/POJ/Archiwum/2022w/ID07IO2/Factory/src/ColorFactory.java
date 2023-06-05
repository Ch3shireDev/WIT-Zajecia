
import java.awt.Color;
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class ColorFactory
{
   private static final HashMap<String,ColorMaker> map=new HashMap<String,ColorMaker>()
   {
      {
         put("Czerwony",(x) -> new Color(255,0,0));
         put("Niebieski",(x) -> Color.BLUE);
         put("Zielony",(x) -> Color.GREEN);
         put("Czarny",(x) -> Color.BLACK);
      }
   };
   private static final List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
   public static Color getValue(String name,int x) { return map.get(name).make(x); }
   public static List<String> getKeys() { return keys; }
   private static interface ColorMaker
   {
      Color make(int x);
   }
}
