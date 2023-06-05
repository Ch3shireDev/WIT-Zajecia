public class AirCondition extends CarDecorator
{
   public AirCondition(Car car) { super(car); }
   public @Override int price() { return super.price()+3000; }
   public @Override String info() { return super.info()+" + Air condition"; }
}
