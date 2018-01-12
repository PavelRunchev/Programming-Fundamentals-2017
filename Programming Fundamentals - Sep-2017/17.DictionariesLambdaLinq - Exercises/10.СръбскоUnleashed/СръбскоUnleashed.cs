using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace СръбскоUnleashed
{
    class СръбскоUnleashed
    {
        static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, decimal>>();
            string pattern = @"^(?<song>.+) @(?<venues>.+) (?<price>[0-9]+) (?<count>[0-9]+)$";
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                Match matches = Regex.Match(input, pattern);
                if (matches.Success)
                {
                    string song = matches.Groups["song"].Value;
                    string venues = matches.Groups["venues"].Value;
                    decimal price = decimal.Parse(matches.Groups["price"].Value);
                    decimal count = decimal.Parse(matches.Groups["count"].Value);
                    if (!data.ContainsKey(venues))
                    {
                        data.Add(venues, new Dictionary<string, decimal>());
                    }
                    if (!data[venues].ContainsKey(song))
                    {
                        data[venues].Add(song, 0);
                    }
                    data[venues][song] += price * count;
                }
            }

            foreach (var venue in data)
            {
                Console.WriteLine($"{venue.Key}");
                foreach (var song in venue.Value.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"#  {song.Key} -> {song.Value}");
                }
            }
        }
    }
}
