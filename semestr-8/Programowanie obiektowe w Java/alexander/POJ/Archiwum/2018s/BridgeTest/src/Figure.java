import java.util.HashMap;
import java.util.Set;

public abstract class Figure 
{
   private static HashMap<String,FigureMaker> map = new HashMap<String,FigureMaker>()
   {
      {
         put("Rectangle", (String params) -> new FigRectangle(params));
         put("Triangle", (String params) -> new FigTriangle(params));
         put("Circle", (String params) -> new FigCircle(params));
      }
   };
   public static Set<String> keys()
   {
      return map.keySet();
   }
   public static Figure make(String kind,String params)
   {
      return map.get(kind).make(params);
   }
}

interface FigureMaker
{
   Figure make(String params);
}