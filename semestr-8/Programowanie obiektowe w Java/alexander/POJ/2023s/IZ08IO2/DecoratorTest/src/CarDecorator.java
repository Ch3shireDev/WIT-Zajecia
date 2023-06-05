public class CarDecorator implements Car
{
    private Car car;
    public CarDecorator(Car car) { this.car=car; }
    @Override public String info() { return car.info(); }
    @Override public int price() { return car.price(); }    
}
