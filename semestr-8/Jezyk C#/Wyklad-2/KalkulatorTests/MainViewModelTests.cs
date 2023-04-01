using Kalkulator.Models;
using Kalkulator.ViewModels;
using Kalkulator.Views;

namespace KalkulatorTests;

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
    public void CalculateAddTest()
    {
        var leftValue = "1";
        var rightValue = "2";
        Operation? oper = Operation.ADD;

        var result = viewModel.Calculate(leftValue, rightValue, oper);

        Assert.AreEqual("3", result);
    }

    [TestMethod]
    public void ExpectErrorOnNull1()
    {
        var leftValue = "";
        var rightValue = "2";
        Operation? oper = Operation.ADD;

        Assert.ThrowsException<Exception>(() => viewModel.Calculate(leftValue, rightValue, oper));
    }

    [TestMethod]
    public void ExpectErrorOnNull2()
    {
        var leftValue = "1";
        var rightValue = "";
        Operation? oper = Operation.ADD;

        Assert.ThrowsException<Exception>(() => viewModel.Calculate(leftValue, rightValue, oper));
    }

    [TestMethod]
    public void ExpectErrorOnNull3()
    {
        var leftValue = "1";
        var rightValue = "2";
        Operation? oper = null;

        Assert.ThrowsException<Exception>(() => viewModel.Calculate(leftValue, rightValue, oper));
    }

    [TestMethod]
    public void OtherAddTest()
    {
        var leftVaue = "5";
        var rightValue = "2";
        var result = viewModel.Calculate(leftVaue, rightValue, Operation.ADD);

        Assert.AreEqual("7", result);
    }

    [TestMethod]
    public void AddNegative()
    {
        var leftVaue = "-5";
        var rightValue = "2";
        var result = viewModel.Calculate(leftVaue, rightValue, Operation.ADD);

        Assert.AreEqual("-3", result);
    }

    [TestMethod]
    public void SubtractTest()
    {
        var leftValue = "10";
        var rightValue = "15";
        var operation = Operation.SUBTRACT;

        var result = viewModel.Calculate(leftValue, rightValue, operation);

        Assert.AreEqual("-5", result);
    }

    [TestMethod]
    public void MultiplyTest()
    {
        var leftValue = "3";
        var rightValue = "7";
        var operation = Operation.MULTIPLY;

        var result = viewModel.Calculate(leftValue, rightValue, operation);

        Assert.AreEqual("21", result);
    }

    [TestMethod]
    public void DivideTest()
    {
        var leftValue = "24";
        var rightValue = "6";
        var operation = Operation.DIVIDE;

        var result = viewModel.Calculate(leftValue, rightValue, operation);

        Assert.AreEqual("4", result);
    }

    [TestMethod]
    public void DivideByZeroTest()
    {
        var leftValue = "24";
        var rightValue = "0";
        var operation = Operation.DIVIDE;

        Assert.ThrowsException<InvalidOperationException>(() => viewModel.Calculate(leftValue, rightValue, operation));
    }

    [TestMethod]
    public void WeirdAddTest()
    {
        var leftValue = "0.1";
        var rightValue = "0.2";
        var operation = Operation.ADD;

        var result = viewModel.Calculate(leftValue, rightValue, operation);

        Assert.AreEqual("0.3", result);
    }

    [TestMethod]
    public void HandleSpacesTest()
    {
        var leftValue = "  1    ";
        var rightValue = "   2   ";
        Operation? oper = Operation.ADD;

        var result = viewModel.Calculate(leftValue, rightValue, oper);

        Assert.AreEqual("3", result);
    }

    [TestMethod]
    public void HandleCommasTest()
    {
        var leftValue = "1,5";
        var rightValue = "2,5";
        Operation? oper = Operation.ADD;

        var result = viewModel.Calculate(leftValue, rightValue, oper);

        Assert.AreEqual("4.0", result);
    }

    [TestMethod]
    public void ValidateTest()
    {
        var invalidValue = "123aa22";

        var isValid = false;
        var isInvalid = false;

        var onCorrect = () => {  isValid = true; };
        var onIncorrect = () => { isInvalid = true; };

        viewModel.ValidateInput(invalidValue, onCorrect, onIncorrect);

        Assert.AreEqual(false, isValid);
        Assert.AreEqual(true, isInvalid);
    }
}