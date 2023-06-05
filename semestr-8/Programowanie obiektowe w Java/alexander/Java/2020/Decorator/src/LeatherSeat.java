public class LeatherSeat extends CarDecorator
{
   public LeatherSeat(Car car) { super(car); }
   public String info() { return super.info() + " + Leather Seat"; }
   public double price() { return super.price() + 3000; }
}
