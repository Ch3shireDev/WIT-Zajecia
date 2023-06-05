
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class GraphReprezentationFabric
{
   private static HashMap<String,IGraphReprezentation> map=new HashMap<String,IGraphReprezentation>()
   {
      {
         put("Human",new IGraphHuman());
         put("List",new IGraphList());
         put("Matrix",new IGraphMatrix());
      }
   };
   public static List<String> getKeys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
   public static IGraphReprezentation get(String kind)
   {
      return map.get(kind);
   }
}