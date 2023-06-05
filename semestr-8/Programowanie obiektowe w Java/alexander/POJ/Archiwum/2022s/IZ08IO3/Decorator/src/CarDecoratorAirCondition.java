public class CarDecoratorAirCondition extends CarDecorator
{
   public CarDecoratorAirCondition(Car car) { super(car); }
   @Override public String info() { return super.info()+" + Klimatyzacja"; }
   @Override public int price() { return super.price()+5000; }
}
