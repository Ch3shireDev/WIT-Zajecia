public class Climatization extends DecoratorCar
{
   public Climatization(BaseCar car) { super(car); }
   @Override public String about() { return super.about()+" + Climatization"; }
   @Override public int price() { return super.price()+300; }
}
