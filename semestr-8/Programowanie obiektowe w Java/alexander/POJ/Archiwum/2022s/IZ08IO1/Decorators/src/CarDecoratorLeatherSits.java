public class CarDecoratorLeatherSits extends CarDecorator
{
   public CarDecoratorLeatherSits(Car car) { super(car); }
   @Override public int price() { return super.price()+2000; }
   @Override public String info() { return super.info()+" + Leather Sits"; }
}
