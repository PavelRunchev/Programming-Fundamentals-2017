using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Raincast
{
    class Raincast
    {
        static void Main()
        {
            string patternType = @"^Type: (?<type>[Normal|Warning|Danger]{6,7})$";
            string patternSource = @"^Source: (?<source>[A-Za-z0-9]+)$";
            string patternForecast = @"^Forecast: (?<forecast>.*)$";
            Regex regexType = new Regex(patternType);
            Regex regexSource = new Regex(patternSource);
            Regex regexForecast = new Regex(patternForecast);
            List<string> result = new List<string>();

            string type = string.Empty;
            string source = string.Empty;
            string forecast = string.Empty;
            bool findType = false;
            bool findSource = false;
            bool findForecast = false;
            
            string input;
            while ((input = Console.ReadLine()) != "Davai Emo")
            {
                Match matchType = regexType.Match(input);
                Match matchSource = regexSource.Match(input);
                Match matchForecast = regexForecast.Match(input);

                string raincast = string.Empty;
                if (matchType.Success && !findType)
                {
                    findSource = true;
                    type = matchType.Groups["type"].Value;
                    findType = true;
                }
                else if(matchSource.Success && findSource)
                {
                    source = matchSource.Groups["source"].Value;
                    findSource = false;
                    findForecast = true;
                }
                else if(matchForecast.Success && findForecast)
                {
                    forecast = matchForecast.Groups["forecast"].Value;

                    if (!forecast.Contains("!") && !forecast.Contains(".") 
                        && !forecast.Contains(",") && !forecast.Contains("?"))
                    {                
                        findForecast = false;
                        findType = false;
                        raincast = "(" + type + ") " + forecast + " ~ " + source;
                        result.Add(raincast);
                    }
                } 
            }

            foreach (var cast in result)
            {
                Console.WriteLine(cast);
            }
        }
    }
}
