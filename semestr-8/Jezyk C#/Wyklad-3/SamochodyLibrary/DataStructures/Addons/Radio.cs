using SamochodyLibrary.DataStructures.Cars;

namespace SamochodyLibrary.DataStructures.Addons;

public class Radio : CarDecorator
{
    public Radio(Car car) : base(car)
    {
    }

    public override string name()
    {
        return "Radio";
    }

    public override string info()
    {
        return base.info() + " + Radio";
    }

    public override decimal price()
    {
        return base.price() + 5000M;
    }
}