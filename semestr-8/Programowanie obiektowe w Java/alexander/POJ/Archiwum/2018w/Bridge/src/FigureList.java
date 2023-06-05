
import java.util.ArrayList;

public class FigureList
{
   private final ArrayList<Figure> lst=new ArrayList<>();
   public void add(Figure fig) { lst.add(fig); }
   public ArrayList<Figure> getData() { return lst; }
   public void Draw(Screen screen) { screen.Draw(this); }
}
