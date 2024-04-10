using Weather_System_Lib;

WeatherData wd = WeatherData.GetInstance;

wd.Attach(new CurrentConditionsDisplay());
wd.Attach(new ForecastDisplay());
wd.Attach(new StatisticsDisplay());

for (int i = 0; i < 1; i++)
        {
            Random rd = new Random();

            double temperature = rd.Next(60, 90);
            double humidity = rd.Next(40, 80);
            double pressure = rd.Next(990, 1010);
            wd.SetMeasurements(temperature, humidity, pressure);
            Console.WriteLine("-------------------");
        }