public class CarDecorator implements Car
{
   protected Car car;
   public CarDecorator(Car car) { this.car=car; }
   public @Override String info() { return car.info(); }
   public @Override double price() { return car.price(); }
}
