public class CarDecoratorWinterTire extends CarDecorator
{
   public CarDecoratorWinterTire(Car car) { super(car); }
   @Override public int price() { return super.price()+1000; }
   @Override public String info() { return super.info()+" + Winter Tire"; }
}
