public abstract class CarDecorator implements Car
{
   private final Car car;
   public CarDecorator(Car car) { this.car=car; }
   public Car getCar() { return car; }
}
