/// <summary>
/// Represents the weather station factory.
/// </summary>
public class WeatherStation
{

    public void IDisplay SelectDisplay (string choice)
    {

        switch (choice)
        {
            case "1":
                CurrentConditionsDisplay ccd = new CurrentConditionsDisplay();
                return ccd;
                // break;
            case "2":
                ForecastDisplay fd = new ForecastDisplay();
                return fd;
                // break;
            case "3":
                StatisticsDisplay sd = new StatisticsDisplay();
                return sd;
                // break;
            default:
                Console.WriteLine("Invalid choice.");
                return;

        }
        
}
}
