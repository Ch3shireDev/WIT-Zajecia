public class TintedWindow extends CarDecorator
{
   public TintedWindow(Car car) { super(car); }
   public String info() { return super.info() + " + Tinted Window"; }
   public double price() { return super.price() + 5000; }
}
