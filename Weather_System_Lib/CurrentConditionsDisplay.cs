/// <summary>
/// Represents the current conditions display.
/// </summary>
public class CurrentConditionsDisplay : IDisplay
{
    private readonly WeatherData weatherData;

    private CurrentConditionsDisplay()
    {
        weatherData = WeatherData.GetInstance();
    }

    public static CurrentConditionsDisplay GetInstance()
    {
        return new CurrentConditionsDisplay();
    }

    public void Update()
    {
        Display();
    }

    public void Display()
    {
        float temperature = weatherData.GetTemperature();
        float humidity = weatherData.GetHumidity();
        float pressure = weatherData.GetPressure();

        // Display current conditions
        Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
    }
}
