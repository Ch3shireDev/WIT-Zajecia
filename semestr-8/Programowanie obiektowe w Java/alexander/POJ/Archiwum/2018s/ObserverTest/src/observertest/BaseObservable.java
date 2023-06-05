package observertest;

import java.util.ArrayList;

public class BaseObservable implements Observable
{
   private final ArrayList<Observer> list=new ArrayList<>();
   @Override public void notifyObservers() { list.forEach((ob) -> ob.sygnal()); }
   @Override public void addObserver(Observer ob) { list.add(ob); }
   @Override public void dropObserver(Observer ob) { list.remove(ob); }
}
