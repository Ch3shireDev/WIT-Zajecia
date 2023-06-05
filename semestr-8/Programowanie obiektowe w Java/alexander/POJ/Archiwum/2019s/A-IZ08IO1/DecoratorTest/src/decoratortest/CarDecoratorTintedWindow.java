package decoratortest;

public class CarDecoratorTintedWindow extends CarDecorator
{
   public CarDecoratorTintedWindow(Car car) { super(car); }
   @Override public String Info() { return car.Info() + " + Tinted Window"; }
   @Override public double Price() { return car.Price() + 4000; }
}
