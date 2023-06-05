public class LeatherSeats extends Decorator
{
   public LeatherSeats(Car car) { super(car); }
   @Override public String info() { return super.info()+" + Szkórzane siedzenia"; }
   @Override public int price() { return super.price()+4000; }
}
