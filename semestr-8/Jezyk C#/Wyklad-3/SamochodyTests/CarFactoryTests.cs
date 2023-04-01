using SamochodyLibrary;

namespace SamochodyTests
{
    [TestClass]
    public class CarFactoryTests
    {
        [TestMethod]
        public void CreateCarWithoutAddonsTest()
        {
            var car = CarFactory.make("Volvo");

            Assert.AreEqual("Volvo", car.info());
        }
    }
}