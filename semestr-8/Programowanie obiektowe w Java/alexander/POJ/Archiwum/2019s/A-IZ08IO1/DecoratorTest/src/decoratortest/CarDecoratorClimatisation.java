package decoratortest;

public class CarDecoratorClimatisation extends CarDecorator
{
   public CarDecoratorClimatisation(Car car) { super(car); }
   @Override public String Info() { return car.Info() + " + Climatisation"; }
   @Override public double Price() { return car.Price() + 4000; }
}
