// WeatherStation.cs
public class WeatherStation
{
    public IDisplay CreateDisplay(DisplayType type)
    {
        switch (type)
        {
            case DisplayType.CurrentConditions:
                return CurrentConditionsDisplay.GetInstance();
            case DisplayType.Statistics:
                return StatisticsDisplay.GetInstance();
            case DisplayType.Forecast:
                return ForecastDisplay.GetInstance();
            default:
                throw new ArgumentException("Invalid display type");
        }
    }
    public void GetUserInput()
    {
        Console.WriteLine("Select display type:");
        Console.WriteLine("1. Current Conditions");
        Console.WriteLine("2. Statistics");
        Console.WriteLine("3. Forecast");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();
        DisplayType displayType;

        switch (choice)
        {
            case "1":
                displayType = DisplayType.CurrentConditions;
                break;
            case "2":
                displayType = DisplayType.Statistics;
                break;
            case "3":
                displayType = DisplayType.Forecast;
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }
}
}
public enum DisplayType
{
    CurrentConditions,
    Statistics,
    Forecast
}
