/// <summary>
/// Represents the current conditions display.
/// </summary>
// CurrentConditionsDisplay Observer and Decorator
public class CurrentConditionsDisplay : IDisplay
{
    private double temperature;
    private double humidity;
    private double pressure;

    public void Display(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
    
        Console.WriteLine($"Current Conditions: {temperature}F, {humidity}% humidity, {pressure}Pa pressure");
    }
}