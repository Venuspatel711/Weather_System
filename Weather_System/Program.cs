using Weather_System_Lib;

WeatherData wd = WeatherData.GetInstance;

wd.Attach(new CurrentConditionsDisplay());

Random rd = new Random();
for (int i = 0; i < 5; i++)
        {
            double temperature = rd.Next(60, 90);
            double humidity = rd.Next(40, 80);
            double pressure = rd.Next(990, 1010);
            wd.SetMeasurements(temperature, humidity, pressure);
            Console.WriteLine("-------------------");
        }