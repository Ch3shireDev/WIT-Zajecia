
import java.util.List;

public abstract class ShapeBridge
{
   protected abstract void init();
   protected abstract void Proceed(Shape shape);
   protected abstract void finish();
   public void Proceed(List<Shape> shapes)
   {
      init();
      for(Shape shape:shapes) Proceed(shape);
      finish();
   }
}
