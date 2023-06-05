public class DecoratorCar extends BaseCar
{
   private BaseCar car;
   public DecoratorCar(BaseCar car) { this.car=car; }
   @Override public String about() { return car.about(); }
   @Override public int price() { return car.price(); }
}
