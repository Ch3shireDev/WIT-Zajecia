using SamochodyLibrary.DataStructures.Cars;

namespace SamochodyLibrary.DataStructures.Addons;

public class ParkingSensors : CarDecorator
{
    public ParkingSensors(Car car) : base(car)
    {
    }

    public override string name()
    {
        return "Parking sensors";
    }

    public override string info()
    {
        return base.info() + " + Parking sensors";
    }

    public override decimal price()
    {
        return base.price() + 4000M;
    }
}