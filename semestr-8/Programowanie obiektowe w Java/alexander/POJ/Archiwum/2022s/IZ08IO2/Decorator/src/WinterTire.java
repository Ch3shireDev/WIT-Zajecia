public class WinterTire extends Decorator
{
   public WinterTire(Car car) { super(car); }
   @Override public String info() { return super.info()+" + Zimowe Opony"; }
   @Override public int price() { return super.price()+1000; }
}
