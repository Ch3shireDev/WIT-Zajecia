using SamochodyLibrary.DataStructures.Cars;

namespace SamochodyLibrary.DataStructures.Addons;

public class Navigation : CarDecorator
{
    public Navigation(Car car) : base(car)
    {
    }

    public override string name()
    {
        return "GPS";
    }

    public override string info()
    {
        return base.info() + " + GPS";
    }

    public override decimal price()
    {
        return base.price() + 3000M;
    }
}