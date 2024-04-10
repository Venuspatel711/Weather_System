namespace Weather_System_Lib;
using System.Collections.Generic;
/// <summary>
/// Represents the weather data subject.
/// </summary>

public class WeatherData
{
    private static WeatherData instance;
    //private readonly Random random;
    private double temperature;
    private double humidity;
    private double pressure;

    private List<IDisplay> shows = new List<IDisplay>();

    private WeatherData()
    {
    }

    public static WeatherData GetInstance
    {
        get
        {
            if(instance == null)
            {
                instance = new WeatherData();    
            }
            return instance;
        }
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature; //random.Next(-20, 40);
        this.humidity = humidity; //random.Next(0, 100);
        this.pressure = pressure; //random.Next(980, 1040);
        Notify();
    }
    
    public void Attach(IDisplay show)
    {
        shows.Add(show);
    }

    public void Deattach(IDisplay show)
    {
        shows.Remove(show);
    }
   
    private void Notify()
    {
        foreach (var show in shows)
        {
            show.Display(temperature,humidity,pressure);
        }
    }
}
