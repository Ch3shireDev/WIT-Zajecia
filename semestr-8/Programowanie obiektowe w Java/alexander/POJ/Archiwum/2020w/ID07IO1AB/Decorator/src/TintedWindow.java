public class TintedWindow extends CarDecorator
{
   public TintedWindow(Car car) { super(car); }
   public @Override int price() { return super.price()+5000; }
   public @Override String info() { return super.info()+" + Tinted window"; }
}
