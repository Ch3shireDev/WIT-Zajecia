namespace SamochodyLibrary.DataStructures.Cars;

public class Seat : Car
{
    public override string info()
    {
        return "Seat";
    }

    public override decimal price()
    {
        return 200000;
    }
}