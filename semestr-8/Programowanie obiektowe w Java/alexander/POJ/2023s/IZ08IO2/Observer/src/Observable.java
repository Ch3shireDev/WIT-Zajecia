
import java.util.HashSet;

public class Observable
{
    private HashSet<Observer> list=new HashSet<>();
    public void addObserver(Observer ob) { list.add(ob); }
    public void removeObserver(Observer ob) { list.remove(ob); }
    public void clear() { list.clear(); }
    public void event()
    {
        for (Observer observer : list) observer.sygnal(this);
    }
}
