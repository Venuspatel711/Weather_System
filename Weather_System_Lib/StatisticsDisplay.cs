public class StatisticsDisplay : IDisplay
{
    private List<double> temperatures = new List<double>();

    public void Display(double temperature, double humidity, double pressure)
    {
        temperatures.Add(temperature);
        Display();
    }

    public void Display()
    {
        double average = temperatures.Count > 0 ? temperatures.Average() : 0;
        double max = temperatures.Count > 0 ? temperatures.Max() : 0;
        double min = temperatures.Count > 0 ? temperatures.Min() : 0;
        Console.WriteLine($"Average Temperature: {average}F, Maximum Temperature: {max}F, Minimum Temperature: {min}F");
    }
}

