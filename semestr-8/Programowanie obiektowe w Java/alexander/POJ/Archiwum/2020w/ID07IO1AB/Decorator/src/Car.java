public abstract class Car
{
   public abstract int price();
   public abstract String info();
   public @Override String toString()
   {
      return String.format("%8d: %s",price(),info());
   }
}
