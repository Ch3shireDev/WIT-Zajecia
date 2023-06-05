public class CarDecoratorTintedWindow extends CarDecorator
{
   public CarDecoratorTintedWindow(Car car) { super(car); }
   @Override public String info() { return super.info()+" + Tonowane szyby"; }
   @Override public int price() { return super.price()+8000; }
}
