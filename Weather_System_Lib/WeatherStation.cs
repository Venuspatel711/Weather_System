/// <summary>
/// Represents the weather station factory.
/// </summary>
public class WeatherStation
{

    public static IDisplay SelectDisplay (string choice)
    {

        switch (choice)
        {
            case "1":
           CurrentConditionsDisplay ccd = new CurrentConditionsDisplay();
           return ccd;
                
            break;
            case "2":
            StatisticsDisplay sd = new StatisticsDisplay();
            return sd;
            break;
            
            case "3":
            ForecastDisplay fd = new ForecastDisplay();
            return fd;
            break;

            default:
            throw new Exception("Invalid choice.");


        }
        
}
}
