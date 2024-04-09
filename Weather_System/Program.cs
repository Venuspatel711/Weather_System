// Program.cs
class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = WeatherData.GetInstance();
        WeatherStation weatherStation = new WeatherStation();
        weatherStation.GetUserInput();

        weatherData.SetMeasurements();
        weatherData.SetMeasurements();
        weatherData.SetMeasurements();
    }
}
