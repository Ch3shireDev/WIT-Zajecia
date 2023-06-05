public class CarDecoratorTintedWindow extends CarDecorator
{
   public CarDecoratorTintedWindow(Car car) { super(car); }
   @Override public int price() { return super.price()+3000; }
   @Override public String info() { return super.info()+" + Tinted Window"; }
}
