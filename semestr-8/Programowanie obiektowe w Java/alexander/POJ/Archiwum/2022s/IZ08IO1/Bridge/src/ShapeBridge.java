import java.util.List;


public interface ShapeBridge
{
   public void init();
   public void finit();
   public void proceed(Shape shape);
   public default void proceed(List<Shape> shapes)
   {
      init();
      for(Shape shape:shapes) proceed(shape);
      finit();
   }
}
