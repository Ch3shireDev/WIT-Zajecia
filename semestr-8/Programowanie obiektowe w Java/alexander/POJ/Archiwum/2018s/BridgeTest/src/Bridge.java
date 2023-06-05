import java.util.ArrayList;

public abstract class Bridge 
{
   protected abstract void init();
   protected abstract void draw(Figure fig);
   protected abstract void done();
   public void draw(ArrayList<Figure> lst)
   {
      init();
      lst.forEach((fig) -> draw(fig));
      done();
   }
}
