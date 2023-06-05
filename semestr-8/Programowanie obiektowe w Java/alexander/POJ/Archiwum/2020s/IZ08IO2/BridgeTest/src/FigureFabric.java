
import java.util.List;
import java.util.HashMap;
import java.util.stream.Collectors;

public class FigureFabric
{
   private static final HashMap<String,FigureMaker> map=new HashMap<String,FigureMaker>()
   {
      {
         put("Circle", (tb) -> new FigCircle(tb));
         put("Triangle", (tb) -> new FigTriangle(tb));
         put("Rectangle", (tb) -> new FigRectangle(tb));
      }
   };
   public static List<String> getKeys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
   public static Figure make(String kind, String parameters)
   {
      String[] p=parameters.split("[\\s\t,;]+");
      int[] tb=new int[p.length];
      for(int i=0;i<tb.length;++i) tb[i]=Integer.parseInt(p[i]);
      return map.get(kind).make(tb);
   }
}

interface FigureMaker
{
   Figure make(int[] tb);
}
