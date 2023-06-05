package decoratortest;

public class CarDecoratorLeatherSeats extends CarDecorator
{
   public CarDecoratorLeatherSeats(Car car) { super(car); }
   @Override public String Info() { return car.Info() + " + Leather seats"; }
   @Override public double Price() { return car.Price() + 3000; }
}
