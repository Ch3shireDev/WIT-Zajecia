using Kalkulator.Models;

namespace KalkulatorTests;

[TestClass]
public class ValidatorTests
{
    private Validator validator;

    [TestInitialize]
    public void Initialize()
    {
        validator = new Validator();
    }

    [TestMethod]
    [DataRow("")]
    [DataRow(null)]
    [DataRow("   ")]
    [DataRow("123dd")]
    public void EmptyTest(string value)
    {
        Assert.ThrowsException<Exception>(() => validator.Validate(value));
    }

}