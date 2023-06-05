public class AirCondition extends CarDecorator
{
    public AirCondition(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Air Condition";}
    @Override public long price() { return super.price()+4000; }
}
