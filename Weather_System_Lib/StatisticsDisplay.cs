public class StatisticsDisplay : IDisplay
{
    private readonly WeatherData weatherData;

    private StatisticsDisplay()
    {
        weatherData = WeatherData.GetInstance();
    }

    public static StatisticsDisplay GetInstance()
    {
        return new StatisticsDisplay();
    }

    public void Update()
    {
        Display();
    }

    public void Display()
    {
        // Calculate and display statistics
        Console.WriteLine("Weather statistics:");
    }
}
