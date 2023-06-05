public class WinterTire extends CarDecorator
{
    public WinterTire(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Winter Tire";}
    @Override public long price() { return super.price()+2000; }
}
