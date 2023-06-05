package observertest;

public interface Observable 
{
   void addObserver(Observer ob);
   void dropObserver(Observer ob);
   void notifyObservers();
   //void clearObservers();
}
