using SamochodyLibrary;
using SamochodyLibrary.DataStructures.Addons;
using SamochodyLibrary.DataStructures.Cars;

namespace SamochodyApp.Models;

public class MainModel
{
    public List<Car> GetCarMakes()
    {
        return new List<Car>
        {
            new Audi(),
            new Volvo(),
            new Seat(),
            new Toyota()
        };
    }

    public List<CarDecorator> GetCarAddons()
    {
        return new List<CarDecorator>
        {
            new AirCondition(new Audi()),
            new LeatherSeats(new Audi()),
            new Navigation(new Audi()),
            new ParkingSensors(new Audi()),
            new Radio(new Audi()),
            new Sunroof(new Audi()),
        };
    }

    public Car GetCar(string make, string[] addons)
    {
        return CarFactory.make(make, addons);
    }
}