import java.util.List;

public interface BridgeFigure
{
   public void initialise();
   public void proceed(Figure fig);
   public void finallise();
   public default void proceed(List<Figure> list)
   {
      initialise();
      for(Figure fig:list) proceed(fig);
      finallise();
   }
}
