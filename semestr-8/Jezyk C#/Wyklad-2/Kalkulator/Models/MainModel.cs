using Kalkulator.Views;

namespace Kalkulator.Models;

public class MainModel
{
    public Validator Validator = new();

    public decimal Calculate(decimal firstValue, decimal secondValue, Operation operation)
    {
        switch (operation)
        {
            case Operation.ADD:
                return firstValue + secondValue;
            case Operation.SUBTRACT:
                return firstValue - secondValue;
            case Operation.MULTIPLY:
                return firstValue * secondValue;
            case Operation.DIVIDE:
                if (secondValue == 0) throw new InvalidOperationException("Pamiętaj cholero, nie dziel przez zero.");

                return firstValue / secondValue;
            default:
                throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
        }
    }

    public void Validate(string firstValueText, string secondValueText, Operation? operation)
    {
        Validator.Validate(firstValueText);
        Validator.Validate(secondValueText);
    }

    public decimal GetValue(string text)
    {
        if (string.IsNullOrWhiteSpace(text)) throw new Exception("Błąd przetwarzania wartości.");

        text = text.Replace(",", ".");

        if (!decimal.TryParse(text, out var value)) throw new Exception("Błąd przetwarzania wartości.");

        return value;
    }
}

public class VisualValidator
{
    
}