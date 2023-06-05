public class CarDecorator extends Car
{
   private final Car car;
   public CarDecorator(Car car) { this.car=car; }
   @Override public int price() { return car.price(); }
   @Override public String info() { return car.info(); }
}
