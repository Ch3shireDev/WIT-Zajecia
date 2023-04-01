using WinFormsApp1;

namespace WinFormsApp1Tests
{
    [TestClass]
    public class MainViewModelTests
    {
        MainViewModel viewModel;

        [TestInitialize]
        public void Initialize()
        {
            viewModel = new MainViewModel();
        }

        [TestMethod]
        public void InvalidValueTest()
        {
            viewModel.InputText = "kopytko";

            var result = viewModel.GetResult();

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void FirstValueTest()
        {
            viewModel.InputText = "1";

            var result = viewModel.GetResult();

            Assert.AreEqual("1", result);
        }
    }
}