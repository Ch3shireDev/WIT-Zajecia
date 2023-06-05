public class TintedWindow extends CarDecorator
{
   public TintedWindow(Car car) { super(car); }
   public @Override String info() { return super.info()+" + Tonowane szyby"; }
   public @Override double price() { return super.price()+12000; }
}
