using ElephantCarpaccio;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 10, "ut", 10.68)]
        [DataRow(3, 40, "ut", 128.22)]
        [DataRow(978, 270.99, "ut", 283182.65)]
        public void CalculatePrice(int quantity, double price, string state, double expected)
        {
            Assert.AreEqual((decimal)expected, Calculator.GetPrice(quantity, (decimal)price, state));
        }
    }
}