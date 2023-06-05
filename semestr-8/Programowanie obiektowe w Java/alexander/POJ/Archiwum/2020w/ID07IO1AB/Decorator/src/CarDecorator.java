public abstract class CarDecorator extends Car
{
   private Car car;
   public CarDecorator(Car car) { this.car=car; }
   public @Override int price() { return car.price(); }
   public @Override String info() { return car.info(); }
}
