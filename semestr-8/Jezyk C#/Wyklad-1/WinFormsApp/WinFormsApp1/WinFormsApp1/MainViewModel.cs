namespace WinFormsApp1;

public class MainViewModel
{
    public MainViewModel()
    {
        Model = new MainModel();
    }

    public EventHandler<int>? UpdateProgress
    {
        get => Model.UpdateProgress;
        set => Model.UpdateProgress = value;
    }

    public MainModel Model { get; set; }
    public string InputText { get; set; } = "";

    private static Color ColorInvalid => SystemColors.ControlDarkDark;
    private static Color ColorValid => SystemColors.InfoText;

    public bool IsValidNumber()
    {
        return Model.IsValidNumber(InputText);
    }

    public Color GetInputForeColor()
    {
        return IsValidNumber() ? ColorValid : ColorInvalid;
    }

    public string GetResult()
    {
        return IsValidNumber() ? Model.GetResult(GetValue()) : "";
    }

    public long GetValue()
    {
        return long.Parse(InputText);
    }
}