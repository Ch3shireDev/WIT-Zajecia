
import java.util.List;

public abstract class ShapeBridge
{
   public abstract void _initialize();
   public abstract void _proceed(Shape shape);
   public abstract void _finalize();
   public void proceed(List<Shape> list)
   {
      _initialize();
      for(Shape shape:list) _proceed(shape);
      _finalize();
   }
}
