public class AirCondition extends CarDecorator
{
   public AirCondition(Car car) { super(car); }
   @Override public String info() { return getCar().info()+" + Klimatyzacja"; }
   @Override public int price() { return getCar().price()+3000; }
}
