
import java.util.ArrayList;
import java.util.Iterator;

public class FigureCollection implements Iterable<Figure>
{
    private final ArrayList<Figure> list=new ArrayList<>();
    @Override public Iterator<Figure> iterator() { return list.iterator(); }    
    public void add(Figure fig) { list.add(fig); }
    public void remove(Figure fig) { list.remove(fig); }
    public void clear() { list.clear(); }
}
