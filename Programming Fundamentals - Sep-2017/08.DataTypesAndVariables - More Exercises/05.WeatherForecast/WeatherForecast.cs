using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class WeatherForecast
    {
        static void Main()
        {
            var number = decimal.Parse(Console.ReadLine());
            sbyte n1;
            int n2;
            long n3;
            decimal n4;
            string weather = string.Empty;
            if(sbyte.TryParse(number.ToString(), out n1))
            {
                weather = "Sunny";
            }
            else if(int.TryParse(number.ToString(), out n2))
            {
                weather = "Cloudy";
            }
            else if (long.TryParse(number.ToString(), out n3))
            {
                weather = "Windy";
            }
            else if(decimal.TryParse(number.ToString(), out n4))
            {
                weather = "Rainy";
            }
            Console.WriteLine(weather);
        }
    }
}
