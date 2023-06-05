public class TintedWindow extends CarDecorator
{
    public TintedWindow(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Tinted Window";}
    @Override public long price() { return super.price()+3000; }
}
