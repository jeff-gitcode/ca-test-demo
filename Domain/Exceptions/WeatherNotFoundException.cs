public sealed class WeatherNotFoundException : Exception
{
    public WeatherNotFoundException(string message) : base(message)
    {
    }
}