using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInformation
{
    class TouristInformation
    {
        static void Main()
        {
            var dataImperialValues = new Dictionary<string, Dictionary<double, string>>
            {
                { "miles", new Dictionary<double, string> { { 1.6, "kilometers" } } },
                { "inches", new Dictionary<double, string> { { 2.54, "centimeters" } } },
                { "feet", new Dictionary<double, string> { { 30, "centimeters" } } },
                { "yards", new Dictionary<double, string> { { 0.91, "meters" } } },
                { "gallons", new Dictionary<double, string> { { 3.8, "liters" } }}
            };

            string unit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            string convertUnit = string.Empty;
            double imperialValue = 0;
            if(dataImperialValues.ContainsKey(unit))
            {
                var units = dataImperialValues[unit]
                    .ToDictionary(k => k.Key, v => v.Value);
                foreach (var values in units)
                {
                    convertUnit = values.Value;
                    imperialValue = values.Key;
                }
            }
            Console.WriteLine($"{value} {unit} = {imperialValue * value:f2} {convertUnit}");
        }
    }
}