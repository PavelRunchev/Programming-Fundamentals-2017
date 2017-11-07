using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Weather
{
    class Weather
    {
        static void Main()
        {
            List<WeatherInfo> dataWeather = new List<WeatherInfo>();
            var regex = new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[a-zA-z]+)\|");

            string input = Console.ReadLine();
            while(input != "end")
            {
                var weather = regex.Match(input);
                if (weather.Success)
                {
                    string city = weather.Groups["city"].Value;
                    string type = weather.Groups["weather"].Value;
                    double averageTemp = double.Parse(weather.Groups["temp"].Value);
                    if (dataWeather.Any(t => t.City == city))
                    {
                        var currentCity = dataWeather.FirstOrDefault(a => a.City == city);
                        currentCity.Type = type;
                        currentCity.AverageTemp = averageTemp;
                    }
                    else
                    {
                        WeatherInfo weatherInfo = new WeatherInfo();
                        weatherInfo.City = city;
                        weatherInfo.Type = type;
                        weatherInfo.AverageTemp = averageTemp;
                        dataWeather.Add(weatherInfo);
                    }
                }
                
                input = Console.ReadLine();
            }

            var orderedCities = dataWeather.OrderBy(temp => temp.AverageTemp).ToList();
            foreach (var Info in orderedCities)
            {
                Console.WriteLine($"{Info.City} => {Info.AverageTemp:f2} => {Info.Type}");
            }
        }
    }

    class WeatherInfo
    {
        public string City { get; set; }
        public string  Type { get; set; }
        public double AverageTemp { get; set; }
    }
}
