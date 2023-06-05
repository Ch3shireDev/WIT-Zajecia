
import java.util.List;

public abstract class ShapesBridge
{
   protected abstract void initialization();
   protected abstract void proceed(Shape shape);
   protected abstract void finalization();
   public void proceed(List<Shape> shapes)
   {
      initialization();
      for(Shape shape:shapes) proceed(shape);
      finalization();
   }
}
