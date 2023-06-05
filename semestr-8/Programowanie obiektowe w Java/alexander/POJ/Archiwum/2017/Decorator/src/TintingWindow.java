public class TintingWindow extends DecoratorCar
{
   public TintingWindow(BaseCar car) { super(car); }
   @Override public String about() { return super.about()+" + Tinting Window"; }
   @Override public int price() { return super.price()+900; }
}
