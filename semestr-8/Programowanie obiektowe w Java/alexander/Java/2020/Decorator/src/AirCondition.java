public class AirCondition extends CarDecorator
{
   public AirCondition(Car car) { super(car); }
   public String info() { return super.info() + " + Air Condition"; }
   public double price() { return super.price() + 4000; }
}
