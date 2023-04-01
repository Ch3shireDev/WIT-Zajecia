using SamochodyLibrary.DataStructures.Addons;
using SamochodyLibrary.DataStructures.Cars;

namespace SamochodyLibrary;

public abstract class CarFactory
{
    private static readonly Dictionary<string, maker> map = new()
    {
        { "Volvo", () => new Volvo() },
        { "Audi", () => new Audi() },
        { "Toyota", () => new Toyota() },
        { "Seat", () => new Seat() }
    };

    private static readonly Dictionary<string, Func<Car, Car>> addons = new()
    {
        { "Air condition", car => new AirCondition(car) },
        { "Leather seats", car => new LeatherSeats(car) },
        { "GPS", car => new Navigation(car) },
        { "Parking sensors", car => new ParkingSensors(car) },
        { "Radio", car => new Radio(car) },
        { "Sunroof", car => new Sunroof(car) }
    };

    public static readonly string[] Models = map.Keys.OrderBy(m => m).ToArray();

    public static Car make(string model, params string[] addons)
    {
        var car = map[model]();

        foreach (var addon in addons) car = CarFactory.addons[addon].Invoke(car);

        return car;
    }

    private delegate Car maker();
}