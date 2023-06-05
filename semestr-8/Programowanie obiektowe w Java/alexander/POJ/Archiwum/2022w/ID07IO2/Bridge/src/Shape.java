
import java.awt.Graphics;
import java.security.InvalidParameterException;
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;
import javafx.scene.shape.Circle;

public abstract class Shape
{
   public static int[] parseParameters(String text,int count)
   {
      String[] parameters=text.split("[\\s\t,;]+");
      if(parameters.length!=count) throw new InvalidParameterException(String.format("Invalid parameters count, expected $d",count));
      int[] result=new int[count];
      for(int i=0;i<count;++i) result[i]=Integer.parseInt(parameters[i]);
      return result;
   }
   public abstract void draw(Graphics g);
   public abstract String xml();
   private static interface ShapeMaker { public Shape make(String text); }
   private static HashMap<String,ShapeMaker> map=new HashMap<String,ShapeMaker>()
   {
      {
         put("Okrąg",(text) -> new ShapeCircle(text));
      }
   };
   private static List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
   public static List<String> keyList() { return keys; }
   public static Shape make(String kind,String text) { return map.get(kind).make(text); }
}
