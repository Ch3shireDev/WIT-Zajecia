using SamochodyApp.Models;
using SamochodyApp.ViewModels;

namespace SamochodyTests;

[TestClass]
public class MainViewModelTests
{
    private MainModel model;
    private MainViewModel viewModel;

    [TestInitialize]
    public void Initialize()
    {
        model = new MainModel();
        viewModel = new MainViewModel(model);
    }

    [TestMethod]
    public void GetCarMakesTest()
    {
        var carMakes = viewModel.GetCarMakes();

        Assert.AreEqual(4, carMakes.Count);
        Assert.AreEqual("Audi", carMakes[0]);
        Assert.AreEqual("Volvo", carMakes[1]);
        Assert.AreEqual("Seat", carMakes[2]);
        Assert.AreEqual("Toyota", carMakes[3]);
    }

    [TestMethod]
    public void GetCarAddonsTest()
    {
        var carAddons = viewModel.GetCarAddons();

        Assert.AreEqual(6, carAddons.Count);
        Assert.AreEqual("Air condition", carAddons[0]);
        Assert.AreEqual("Leather seats", carAddons[1]);
        Assert.AreEqual("GPS", carAddons[2]);
        Assert.AreEqual("Parking sensors", carAddons[3]);
        Assert.AreEqual("Radio", carAddons[4]);
        Assert.AreEqual("Sunroof", carAddons[5]);
    }

    [TestMethod]
    public void AddCarTest()
    {
        var carMakes = viewModel.GetCarMakes();
        var carAddons = viewModel.GetCarAddons();
        var selectedCars = viewModel.GetSelectedCars();

        Assert.AreEqual(0, selectedCars.Count);

        viewModel.AddCar(carMakes[0], new[] { carAddons[0], carAddons[1] });

        Assert.AreEqual(1, selectedCars.Count);
        Assert.AreEqual("Audi + Air condition + Leather seats (153000)", selectedCars[0]);
    }
}