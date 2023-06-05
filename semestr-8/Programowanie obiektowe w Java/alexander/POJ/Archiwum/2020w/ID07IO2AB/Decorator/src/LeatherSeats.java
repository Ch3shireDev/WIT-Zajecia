public class LeatherSeats extends CarDecorator
{
   public LeatherSeats(Car car) { super(car); }
   @Override public int price() { return super.price()+6000; }
   @Override public String info() { return super.info()+" + leather seats"; }
}
