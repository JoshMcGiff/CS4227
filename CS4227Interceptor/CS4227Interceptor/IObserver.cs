namespace CS4227Interceptor
{
    public interface IObserver
    {
        public void update(float temp, float humidity, float pressure);
    }
}