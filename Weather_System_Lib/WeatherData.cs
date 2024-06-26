namespace Weather_System_Lib;
using System.Collections.Generic;
/// <summary>
/// it represents the weather data subject of project.
/// </summary>

public class WeatherData
{
    private static WeatherData instance;
    //private readonly Random random;
    public double temperature;
    public double humidity;
    public double pressure;

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
