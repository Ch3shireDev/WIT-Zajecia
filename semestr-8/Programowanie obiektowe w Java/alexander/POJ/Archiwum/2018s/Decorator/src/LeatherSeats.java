public class LeatherSeats extends CarDecorator
{
   public LeatherSeats(Car car) { super(car); }
   public @Override String info() { return super.info()+" + Skórzana tapicerka"; }
   public @Override double price() { return super.price()+15000; }
}
