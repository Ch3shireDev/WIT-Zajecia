using SamochodyApp.Models;
using System.Collections.ObjectModel;

namespace SamochodyApp.ViewModels;

public class MainViewModel
{
    private readonly MainModel _model;

    public MainViewModel(MainModel model)
    {
        _model = model;
    }

    private ObservableCollection<string> SelectedCars { get; } = new ObservableCollection<string>();


    public List<string> GetCarMakes()
    {
        return _model.GetCarMakes().Select(c => c.info()).ToList();
    }

    public List<string> GetCarAddons()
    {
        return _model.GetCarAddons().Select(c=>c.name()).ToList();
    }

    public ObservableCollection<string> GetSelectedCars()
    {
        return SelectedCars;
    }

    public void AddCar(string make, string[] addons)
    {
        var car = _model.GetCar(make, addons);
        SelectedCars.Add(car.info() + $" ({car.price()})");
    }
}