public class WinterTire extends DecoratorCar
{
   public WinterTire(BaseCar car) { super(car); }
   @Override public String about() { return super.about()+" + Winter Tire"; }
   @Override public int price() { return super.price()+600; }
}
