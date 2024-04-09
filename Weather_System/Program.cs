// Program.cs
class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = WeatherData.GetInstance();
        WeatherStation weatherStation = new WeatherStation();
        weatherStation.GetUserInput();

        // Simulate weather data changes
        weatherData.SetMeasurements();
        weatherData.SetMeasurements();
        weatherData.SetMeasurements();
    }
}
