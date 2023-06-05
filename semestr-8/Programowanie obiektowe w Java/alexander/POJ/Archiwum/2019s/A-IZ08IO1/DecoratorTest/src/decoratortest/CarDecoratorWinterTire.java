package decoratortest;

public class CarDecoratorWinterTire extends CarDecorator
{
   public CarDecoratorWinterTire(Car car) { super(car); }
   @Override public String Info() { return car.Info() + " + Winter tire"; }
   @Override public double Price() { return car.Price() + 4000; }
}
