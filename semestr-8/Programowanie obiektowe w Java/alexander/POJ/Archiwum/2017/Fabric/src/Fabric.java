
import java.util.HashMap;

public class Fabric 
{
   //*///
   private static HashMap<String,ComboListMaker> map=new HashMap<String,ComboListMaker>()
   {
      {
         put("Colors", () -> new Colors());
         put("Shapes", () -> new Shapes());
      }
   };
   /*/
   private static HashMap<String,ComboListMaker> map=map();
   private static HashMap<String,ComboListMaker> map()
   {
      final HashMap<String,ComboListMaker> map=new HashMap<String,ComboListMaker>();
      map.put("Colors", () -> new Colors());
      map.put("Shapes", () -> new Shapes());
      return map;
   }
   //*///
   private final ComboListMaker maker;
   public Fabric(String kind)
   {
      maker=map.get(kind);
   }
   public ComboList make()
   {
      return maker.make();
   }
}
