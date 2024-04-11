/// <summary>
/// it represents the forecast display of project.
/// </summary>

public class ForecastDisplay : IDisplay
{
    public void Display(double temperature, double humidity, double pressure)
    {
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Weather Forecast: Sunny");
    }
}

