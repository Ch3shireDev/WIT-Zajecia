
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class ShapeFactory
{
   private static interface ShapeMaker
   {
      public Shape make(String text);
   }
   private static HashMap<String,ShapeMaker> map=new HashMap<String,ShapeMaker>()
   {
      {
         put("Elipsa",(text) -> new ShapeCircle(text));
         put("Prostokąt",(text) -> new ShapeRectangle(text));
         put("Trójkąt",(text) -> new ShapeTriangle(text));
      }
   };
   private static List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
   public static List<String> keySet() { return keys; }
   public static Shape make(String kind,String text) { return map.get(kind).make(text); }
}
