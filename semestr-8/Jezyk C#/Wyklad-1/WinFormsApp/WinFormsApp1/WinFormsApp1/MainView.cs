namespace WinFormsApp1;

public partial class MainView : Form
{
    public MainView()
    {
        InitializeComponent();
        ViewModel = new MainViewModel();
        ViewModel.UpdateProgress += (sender, value) => CalculationProgress.Value = value;
    }

    public MainViewModel ViewModel { get; }

    private void UserInputTB_TextChanged(object sender, EventArgs e)
    {
        ViewModel.InputText = UserInputTB.Text;
        UserInputTB.ForeColor = ViewModel.GetInputForeColor();
    }
    
    private void CalculateButton_Click(object sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;
        UserOutputTB.Text = ViewModel.GetResult();
        Cursor = null;
    }
}