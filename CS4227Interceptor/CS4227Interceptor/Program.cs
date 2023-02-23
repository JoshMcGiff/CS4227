using CS4227Interceptor;

internal class Program
{
    private static void Main(string[] args)
    {
        Framework framework = new Framework();
        framework.SetMeasurements(10,10,10);

        framework.GetTempFahrenheit(25.5f);
    }
}