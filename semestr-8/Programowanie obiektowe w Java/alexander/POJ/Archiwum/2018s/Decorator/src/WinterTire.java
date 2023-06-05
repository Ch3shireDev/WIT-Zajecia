public class WinterTire extends CarDecorator
{
   public WinterTire(Car car) { super(car); }
   public @Override String info() { return super.info()+" + Opony zimowe"; }
   public @Override double price() { return super.price()+8000; }
}
