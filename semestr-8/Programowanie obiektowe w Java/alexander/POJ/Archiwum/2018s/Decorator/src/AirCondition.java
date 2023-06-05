public class AirCondition extends CarDecorator
{
   public AirCondition(Car car) { super(car); }
   public @Override String info() { return super.info()+" + Klimatyzacja"; }
   public @Override double price() { return super.price()+8000; }
}
