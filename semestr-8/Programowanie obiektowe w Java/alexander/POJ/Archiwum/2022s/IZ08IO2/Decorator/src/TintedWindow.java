public class TintedWindow extends Decorator
{
   public TintedWindow(Car car) { super(car); }
   @Override public String info() { return super.info()+" + Tonowane Szyby"; }
   @Override public int price() { return super.price()+5000; }
}
