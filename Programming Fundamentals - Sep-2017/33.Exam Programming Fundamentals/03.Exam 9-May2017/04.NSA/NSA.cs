using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NSA
{
    class NSA
    {
        static void Main()
        {
            var dataNsa = new Dictionary<string, Dictionary<string, int>>();
            string pattern = @"^(?<country>[\w]+) -> (?<spy>[\w]+) -> (?<service>[0-9]+)$";

            string input;
            while ((input = Console.ReadLine()) != "quit")
            {
                Match matchedNSA = Regex.Match(input, pattern);
                if (matchedNSA.Success)
                {
                    string country = matchedNSA.Groups["country"].Value;
                    string spyName = matchedNSA.Groups["spy"].Value;
                    int daysInService = int.Parse(matchedNSA.Groups["service"].Value);
                    if (!dataNsa.ContainsKey(country))
                    {
                        dataNsa.Add(country, new Dictionary<string, int>());
                    }
                    if (!dataNsa[country].ContainsKey(spyName))
                    {
                        dataNsa[country].Add(spyName, 0);
                    }
                    dataNsa[country][spyName] = daysInService;
                }
            }

            Dictionary<string, Dictionary<string, int>> orderedCountriesByAmountSpies = dataNsa
                .OrderByDescending(sp => sp.Value.Count())
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var country in orderedCountriesByAmountSpies)
            {
                string countryName = country.Key;
                Dictionary<string, int> spies = country.Value
                    .OrderByDescending(day => day.Value)
                    .ToDictionary(k => k.Key, v => v.Value);
                Console.WriteLine($"Country: {countryName}");
                foreach (var spy in spies)
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
