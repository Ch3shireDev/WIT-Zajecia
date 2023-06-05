public class Decorator implements Car
{
   private Car car;
   public Decorator(Car car) { this.car=car; }
   public String info() { return car.info(); }
   public int price() { return car.price(); }
}
