import java.util.List;

public abstract class FigureBridge
{
   protected abstract void initialize();
   protected abstract void finalize();
   protected abstract void proceed(Figure fig);
   protected void proceed(List<Figure> list)
   {
      initialize();
      for(Figure fig : list) proceed(fig);
      finalize();
   }
}
