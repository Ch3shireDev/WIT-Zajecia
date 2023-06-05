public class AirCondition extends Decorator
{
   public AirCondition(Car car) { super(car); }
   @Override public String info() { return super.info()+" + Klimatyzacja"; }
   @Override public int price() { return super.price()+2000; }
}
