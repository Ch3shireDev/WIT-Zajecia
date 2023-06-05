
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class FigureFabric
{
   private static final HashMap<String,FigureMaker> map=new HashMap<String,FigureMaker>()
   {
      {
         put("Circle",(tb) -> new FigCircle(tb));
         put("Rectangle",(tb) -> new FigRectangle(tb));
         put("Triangle",(tb) -> new FigTriangle(tb));
      }
   };
   public static List<String> keys()
   {
      return map.keySet().stream().sorted().collect(Collectors.toList());
   }
   public static Figure make(String kind, String parameters)
   {
      String[] param=parameters.split("[\\s\t,;]+");
      int[] tb=new int[param.length];
      for(int i=0;i<tb.length;++i) tb[i]=Integer.parseInt(param[i]);
      return map.get(kind).make(tb);
   }
}
