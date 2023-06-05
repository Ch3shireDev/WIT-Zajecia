public class CarDecorator implements Car
{
   private Car car;
   public CarDecorator(Car car)
   {
      this.car=car;
   }
   public String info() { return car.info(); }
   public double price() { return car.price(); }
}
