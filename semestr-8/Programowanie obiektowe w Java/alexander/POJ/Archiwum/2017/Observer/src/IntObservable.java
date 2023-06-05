public interface IntObservable 
{
   public void addObserver(IntObserver obj);
   public void removeObserver(IntObserver obj);
   public void clearObservers();
}
