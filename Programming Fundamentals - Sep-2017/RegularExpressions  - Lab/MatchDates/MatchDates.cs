using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class MatchDates
    {
        static void Main()
        {
            var inputDates = Console.ReadLine();
            var pattern = @"\b(?<day>[0-9]{2})([\/.-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            MatchCollection dates = Regex.Matches(inputDates, pattern);
            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
