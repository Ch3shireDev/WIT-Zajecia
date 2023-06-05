import java.util.List;

public abstract class ShapesBridge
{
   public abstract void init();
   public abstract void proceed(Shape shape);
   public abstract void finit();
   public void proceed(List<Shape> shapes)
   {
      init();
      for(Shape shape : shapes) proceed(shape);
      finit();
   }
}
