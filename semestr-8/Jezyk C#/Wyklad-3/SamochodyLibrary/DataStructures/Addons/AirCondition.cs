using SamochodyLibrary.DataStructures.Cars;

namespace SamochodyLibrary.DataStructures.Addons;

public class AirCondition : CarDecorator
{
    public AirCondition(Car car) : base(car)
    {
    }

    public override string name()
    {
        return "Air condition";
    }

    public override string info()
    {
        return base.info() + " + Air condition";
    }

    public override decimal price()
    {
        return base.price() + 1000M;
    }
}