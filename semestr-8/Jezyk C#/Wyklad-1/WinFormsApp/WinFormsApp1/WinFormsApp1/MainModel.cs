using System.Globalization;

namespace WinFormsApp1;

public class MainModel
{
    public EventHandler<int>? UpdateProgress;

    public bool IsValidNumber(string text)
    {
        return long.TryParse(text, out _);
    }

    public string GetResult(long number)
    {
        double result = 0;

        for (long i = 1; i <= number; i++)
        {
            result += 1.0 / i;
            UpdateProgress?.Invoke(this, (int)(100.0 * i / number));
        }

        UpdateProgress?.Invoke(this, 100);

        return result.ToString(CultureInfo.InvariantCulture);
    }
}