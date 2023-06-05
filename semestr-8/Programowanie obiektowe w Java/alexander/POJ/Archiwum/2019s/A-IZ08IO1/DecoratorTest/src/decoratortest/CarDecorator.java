package decoratortest;

public abstract class CarDecorator implements Car
{
   protected Car car;
   CarDecorator(Car car) { this.car=car; }
}
