import java.util.ArrayList;

public class BaseObservable implements Observable
{
   private final ArrayList<Observer> lst=new ArrayList<>();
   public void notifyObservers() { for(Observer ob:lst) ob.signal(); } 
   public void addObserver(Observer ob) { lst.add(ob); }
   public void dropObserver(Observer ob) { lst.remove(ob); }
   public void clearObservers() { lst.clear(); }
}
