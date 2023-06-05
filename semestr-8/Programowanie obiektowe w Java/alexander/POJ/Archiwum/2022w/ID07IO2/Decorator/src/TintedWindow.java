public class TintedWindow extends CarDecorator
{
   public TintedWindow(Car car) { super(car); }
   @Override public String info() { return getCar().info()+" + Klimatyzacja"; }
   @Override public int price() { return getCar().price()+3000; }
}
