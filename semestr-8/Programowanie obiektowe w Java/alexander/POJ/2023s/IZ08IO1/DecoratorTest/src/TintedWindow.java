public class TintedWindow extends CarDecorator
{
    public TintedWindow(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Tinted Window"; }
    @Override public int price() { return super.price()+2500; }
}
