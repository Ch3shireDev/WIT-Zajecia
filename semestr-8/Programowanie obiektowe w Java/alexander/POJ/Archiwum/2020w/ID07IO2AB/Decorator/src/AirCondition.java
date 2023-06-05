public class AirCondition extends CarDecorator
{
   public AirCondition(Car car) { super(car); }
   @Override public int price() { return super.price()+4000; }
   @Override public String info() { return super.info()+" + air condition"; }
}
