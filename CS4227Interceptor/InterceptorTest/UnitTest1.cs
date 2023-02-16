namespace InterceptorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTemperature()
        {
            float temperature = 10;
            CS4227Interceptor.Framework framework = new Framework();
            framework.SetMeasurements(temperature, 10, 10);

            Assert.AreEqual(temperature, framework.GetTemperature());
        }

        [TestMethod]
        public void TestHumidity()
        {
            float humidity = 10;
            CS4227Interceptor.Framework framework = new Framework();
            framework.SetMeasurements(10, humidity, 10);

            Assert.AreEqual(humidity, framework.GetHumidity());
        }

        [TestMethod]
        public void TestPressure()
        {
            float pressure = 10;
            CS4227Interceptor.Framework framework = new Framework();
            framework.SetMeasurements(10, 10, pressure);

            Assert.AreEqual(pressure, framework.GetPressure());
        }
    }
}