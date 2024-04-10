/// <summary>
/// Represents the weather forecast display.
/// </summary>
public class ForecastDisplay : IDisplay
{
    private readonly WeatherData weatherData;

    private ForecastDisplay()
    {
        weatherData = WeatherData.GetInstance();
    }

    public static ForecastDisplay GetInstance()
    {
        return new ForecastDisplay();
    }

    public void Update()
    {
        Display();
    }

    public void Display()
    {
        // Display weather forecast
        Console.WriteLine("Weather forecast:");
    }
}
