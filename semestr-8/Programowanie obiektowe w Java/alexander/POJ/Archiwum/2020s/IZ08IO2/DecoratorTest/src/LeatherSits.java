public class LeatherSits extends CarDecorator
{
    public LeatherSits(Car car) { super(car); }
    @Override public String info() { return super.info()+" + Leather Sits";}
    @Override public long price() { return super.price()+5000; }
}
