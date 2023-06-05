public class CarDecoratorAirCondition extends CarDecorator
{
   public CarDecoratorAirCondition(Car car) { super(car); }
   @Override public int price() { return super.price()+5000; }
   @Override public String info() { return super.info()+" + Air Condition"; }
}
