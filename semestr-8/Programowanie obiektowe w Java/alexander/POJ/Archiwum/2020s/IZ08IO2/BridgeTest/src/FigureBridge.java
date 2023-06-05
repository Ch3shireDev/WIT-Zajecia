
import java.util.List;

public abstract class FigureBridge
{
   protected abstract void initialize();
   protected abstract void proceed(Figure fig);
   protected abstract void finalize();
   public void proceed(List<Figure> list)
   {
      initialize();
      for(Figure fig : list) proceed(fig);
      finalize();
   }
}
