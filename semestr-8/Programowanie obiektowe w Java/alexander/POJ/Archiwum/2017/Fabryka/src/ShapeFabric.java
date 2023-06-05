import java.util.HashMap;
import java.util.Set;

public class ShapeFabric 
{
   private static final HashMap<String,ShapeMaker> map=makemap();
   private static HashMap<String,ShapeMaker> makemap()
   {
      final HashMap<String,ShapeMaker> map=new HashMap<String,ShapeMaker>();
      map.put("Circle", new ShapeMaker() { @Override public Shape make(int size) { return new Circle(size); } });
      map.put("Triangle", (ShapeMaker) (int size) -> new Triangle(size) );
      return map;
   };
   
   public static Shape make(String shape,int size)
   {
      return map.get(shape).make(size);
   }
   
   public static Set<String> keySet()
   {
      return map.keySet();
   }
   
   /*
   private static final HashMap<String,ShapeMaker> map=new HashMap<String,ShapeMaker>()
   {
      {"Circle", new ShapeMaker() { @Override public Shape make(int size) { return new Circle(size); } } },
      {"Triangle", (ShapeMaker) (int size) -> new Triangle(size) },
   };*/
}
