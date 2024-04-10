/// <summary>
/// Represents the weather data subject.
/// </summary>

public class WeatherData
{
    private static WeatherData instance;
    private readonly Random random;
    private float temperature;
    private float humidity;
    private float pressure;

    private WeatherData()
    {
        random = new Random();
    }

    public static WeatherData GetInstance()
    {
        return instance ??= new WeatherData();
    }

    public void SetMeasurements()
    {
        temperature = random.Next(-20, 40);
        humidity = random.Next(0, 100);
        pressure = random.Next(980, 1040);
        MeasurementsChanged();
    }

    public float GetTemperature()
    {
        return temperature;
    }

    public float GetHumidity()
    {
        return humidity;
    }

    public float GetPressure()
    {
        return pressure;
    }

    private void MeasurementsChanged()
    {
        CurrentConditionsDisplay.GetInstance().Update();
        StatisticsDisplay.GetInstance().Update();
        ForecastDisplay.GetInstance().Update();
    }
}
