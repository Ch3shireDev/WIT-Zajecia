using SamochodyLibrary.DataStructures.Cars;

namespace SamochodyLibrary.DataStructures.Addons;

public class Sunroof : CarDecorator
{
    public Sunroof(Car car) : base(car)
    {
    }

    public override string name()
    {
        return "Sunroof";
    }

    public override string info()
    {
        return base.info() + " + Sunroof";
    }

    public override decimal price()
    {
        return base.price() + 6000M;
    }
}