public class WinterTire extends CarDecorator
{
   public WinterTire(Car car) { super(car); }
   public String info() { return super.info() + " + Tinted Window"; }
   public double price() { return super.price() + 1000; }
}
