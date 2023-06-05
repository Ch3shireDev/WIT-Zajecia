public abstract class BaseCar 
{
   public abstract String about();
   public abstract int price();
   @Override public String toString()
   {
      return about()+": "+price();
   }
}
