using Weather_System_Lib;

WeatherData wd = WeatherData.GetInstance;

wd.Attach(new CurrentConditionsDisplay());
wd.Attach(new ForecastDisplay());
wd.Attach(new StatisticsDisplay());

for (int i = 0; i < 1; i++)
        {
            Random ad = new Random();
            Console.WriteLine("______************your_data*****************_________________");
            double temperature = ad.Next(60, 90);
            double humidity = ad.Next(40, 80);
            double pressure = ad.Next(990, 1010);
            wd.SetMeasurements(temperature, humidity, pressure);
            Console.WriteLine("______**************************************__________________");
        }