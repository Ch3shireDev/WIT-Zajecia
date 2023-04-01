using SamochodyLibrary.DataStructures.Cars;

namespace SamochodyLibrary.DataStructures.Addons;

public class LeatherSeats : CarDecorator
{
    public LeatherSeats(Car car) : base(car)
    {
    }

    public override string name()
    {
        return "Leather seats";
    }

    public override string info()
    {
        return base.info() + " + Leather seats";
    }

    public override decimal price()
    {
        return base.price() + 2000M;
    }
}