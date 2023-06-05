public interface Observable 
{
   void notifyObservers();
   void addObserver(Observer ob);
   void dropObserver(Observer ob);
   void clearObservers();
}
