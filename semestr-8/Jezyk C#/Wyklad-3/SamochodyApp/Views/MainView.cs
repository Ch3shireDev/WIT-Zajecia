using SamochodyApp.ViewModels;

namespace SamochodyApp.Views;

public partial class MainView : Form
{
    public MainView()
    {
        InitializeComponent();
    }

    public MainViewModel? DataContext { get; set; }

    public void LoadData()
    {
        if (DataContext == null) return;
        CarMakesComboBox.DataSource = DataContext.GetCarMakes();
        AddonsListBox.DataSource = DataContext.GetCarAddons();
        SelectedCarsListBox.DataSource = DataContext.GetSelectedCars();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (DataContext == null) return;

        var selectedMake = CarMakesComboBox.SelectedItem.ToString();

        if (selectedMake == null) return;

        var selectedAddons = AddonsListBox.SelectedItems.Cast<string>().ToArray();

        DataContext.AddCar(selectedMake, selectedAddons);

        SelectedCarsListBox.DataSource = null;
        SelectedCarsListBox.DataSource = DataContext.GetSelectedCars();
    }
}