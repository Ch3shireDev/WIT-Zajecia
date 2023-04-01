using SamochodyLibrary.DataStructures.Cars;

namespace SamochodyLibrary.DataStructures.Addons;

public abstract class CarDecorator:Car
{
    private Car car;

    public abstract string name();
    protected CarDecorator(Car car)
    {
        this.car = car;
    }

    public override string info()
    {
        return car.info();
    }

    public override decimal price()
    {
        return car.price();
    }
}