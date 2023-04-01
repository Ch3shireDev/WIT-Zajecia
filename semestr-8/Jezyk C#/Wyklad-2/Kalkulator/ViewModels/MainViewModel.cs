using System.Globalization;
using Kalkulator.Models;
using Kalkulator.Views;

namespace Kalkulator.ViewModels;

public class MainViewModel
{
    public MainViewModel(MainModel model)
    {
        Model = model;
    }

    public MainModel Model { get; set; }

    public string Calculate(string firstValueText, string secondValueText, Operation? operation)
    {
        Model.Validate(firstValueText, secondValueText, operation);

        if (operation == null) throw new Exception("Należy wybrać rodzaj operacji.");

        var firstValue = Model.GetValue(firstValueText);
        var secondValue = Model.GetValue(secondValueText);

        var result = Model.Calculate(firstValue, secondValue, operation.Value);

        return result.ToString(CultureInfo.InvariantCulture);
    }

    public void ValidateInput(string firstValue, Action onCorrect, Action onIncorrect)
    {
        try
        {
            new Validator().Validate(firstValue);
            onCorrect();
        }
        catch (Exception)
        {
            onIncorrect();
        }
    }
}