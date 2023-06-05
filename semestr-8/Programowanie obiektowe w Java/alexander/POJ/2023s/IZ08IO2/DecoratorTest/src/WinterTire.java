public class WinterTire extends CarDecorator
{
    public WinterTire(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Opony zimowe"; }
    @Override public int price() { return super.price()+2000; }
}
