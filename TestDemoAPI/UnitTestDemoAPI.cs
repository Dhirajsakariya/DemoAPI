using DemoAPI.Controllers;

namespace TestDemoAPI
{
    [TestClass]
    public class UnitTestDemoAPI
    {
        [TestMethod]
        public void TestAdd()
        {
            var demoAPI = new CalculatorController();
            var result = demoAPI.Add(10, 20);
            Assert.AreEqual(30,result);

            result = demoAPI.Add(0, 20);
            Assert.AreEqual(20, result);

            result = demoAPI.Add(0, 0);
            Assert.AreEqual(0, result);

            result = demoAPI.Add(-10, 20);
            Assert.AreEqual(10, result);

            result = demoAPI.Add(10, -20);
            Assert.AreEqual(-10, result);
        }
    }
}