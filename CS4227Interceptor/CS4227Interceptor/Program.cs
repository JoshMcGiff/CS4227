using CS4227Interceptor;

internal class Program
{
    private static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        Proxy proxy = new Proxy(weatherData);
        proxy.AddInterceptor(new ConcreteInterceptor());
        Context context = new Context();
        currentDisplay.display();
        

        proxy.setMeasurements(30, 20, 20, context);
        proxy.setMeasurements(30, 20, 20, context);
        proxy.setMeasurements(30, 20, 20, context);

    }
}