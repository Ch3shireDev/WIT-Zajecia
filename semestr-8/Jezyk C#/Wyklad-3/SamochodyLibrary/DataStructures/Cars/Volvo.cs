namespace SamochodyLibrary.DataStructures.Cars;

public class Volvo : Car
{
    public override string info()
    {
        return "Volvo";
    }

    public override decimal price()
    {
        return 100000M;
    }
}