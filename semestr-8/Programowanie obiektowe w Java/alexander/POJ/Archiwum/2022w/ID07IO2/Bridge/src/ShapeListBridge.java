
import java.util.List;

public abstract class ShapeListBridge
{
   protected abstract void _initialize();
   protected abstract void proceed(Shape shape);
   protected abstract void _finalize();
   public void proceed(List<Shape> shapes)
   {
      _initialize();
      for(Shape shape:shapes) proceed(shape);
      _finalize();
   }
}
