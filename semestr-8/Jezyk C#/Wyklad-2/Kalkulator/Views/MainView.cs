using Kalkulator.ViewModels;

namespace Kalkulator.Views;

public partial class MainView : Form
{
    public MainView()
    {
        InitializeComponent();
        OperationComboBox.Items.Add(Operation.ADD);
        OperationComboBox.Items.Add(Operation.SUBTRACT);
        OperationComboBox.Items.Add(Operation.MULTIPLY);
        OperationComboBox.Items.Add(Operation.DIVIDE);
    }

    public MainViewModel DataContext { get; set; }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        try
        {
            var firstValue = FirstValueTextBox.Text;
            var operation = OperationComboBox.SelectedItem as Operation?;
            var secondValue = SecondValueTextBox.Text;
            var result = DataContext?.Calculate(firstValue, secondValue, operation);
            ResultTextBox.Text = result;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Wystąpił błąd programu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FirstValueTextBox_TextChanged(object sender, EventArgs e)
    {
        var firstValue = FirstValueTextBox.Text;

        var onCorrect = () => { FirstValueTextBox.BackColor = Color.White; };
        var onIncorrect = () => { FirstValueTextBox.BackColor = Color.PaleVioletRed; };

        DataContext?.ValidateInput(firstValue, onCorrect, onIncorrect);

    }

    private void SecondValueTextBox_TextChanged(object sender, EventArgs e)
    {
        var firstValue = SecondValueTextBox.Text;

        var onCorrect = () => { SecondValueTextBox.BackColor = Color.White; };
        var onIncorrect = () => { SecondValueTextBox.BackColor = Color.PaleVioletRed; };

        DataContext?.ValidateInput(firstValue, onCorrect, onIncorrect);
    }
}