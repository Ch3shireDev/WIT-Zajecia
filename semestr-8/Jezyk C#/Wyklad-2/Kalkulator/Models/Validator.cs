namespace Kalkulator.Models;

public class Validator
{
    public void Validate(string value)
    {
        if(string.IsNullOrWhiteSpace(value)) throw new Exception("Wartość nie może być pusta!");
        if(!decimal.TryParse(value, out var decimalValue)) throw new Exception($"Wartość \"{value}\" nie jest liczbą!");
    }
}