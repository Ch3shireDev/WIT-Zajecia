public class LeatherSeats extends CarDecorator
{
   public LeatherSeats(Car car) { super(car); }
   @Override public String info() { return super.info()+" + Leather Seats"; }
   @Override public int price() { return super.price()+9000; }
}
