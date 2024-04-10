/// <summary>
/// Represents the weather station factory.
/// </summary>
public class WeatherStation
{
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
                Console.WriteLine(displayType = DisplayType.CurrentConditions);
                break;
            case "2":
                Console.WriteLine(displayType = DisplayType.Statistics);
                break;
            case "3":
                Console.WriteLine(displayType = DisplayType.Forecast);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
        

}
}
/// <summary>
/// Represents the weather station factory.
/// </summary>
public enum DisplayType
{
    CurrentConditions,
    Statistics,
    Forecast
}
