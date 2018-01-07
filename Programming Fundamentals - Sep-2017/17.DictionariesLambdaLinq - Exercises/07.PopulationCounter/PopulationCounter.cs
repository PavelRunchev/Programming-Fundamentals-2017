using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Statistic
    {
        public string Country { get; set; }
        public long TotalCount { get; set; }
        public Dictionary<string, long> Town { get; set; }
    }
    class PopulationCounter
    {
        static void Main()
        {
            var dataStatistics = new List<Statistic>();

            string[] input = Console.ReadLine().Split('|');
            while(input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);
                if (!dataStatistics.Any(c => c.Country == country))
                {
                    var stat = new Statistic();
                    stat.Country = country;
                    stat.Town = new Dictionary<string, long>();
                    stat.Town.Add(city, population);
                    stat.TotalCount += population;
                    dataStatistics.Add(stat);
                }
                else
                {
                    int index = dataStatistics.IndexOf(dataStatistics.Find(c => c.Country == country));
                    dataStatistics[index].Town.Add(city, population);
                    dataStatistics[index].TotalCount += population;
                }

                input = Console.ReadLine().Split('|');
            }

            dataStatistics = dataStatistics
                .OrderByDescending(p => p.TotalCount)
                .ToList();

            foreach (var stats in dataStatistics)
            {
                Console.WriteLine($"{stats.Country} (total population: {stats.TotalCount})");
                var townsList = stats.Town
                    .OrderByDescending(c => c.Value)
                    .ToDictionary(k => k.Key, v => v.Value);
                foreach (var statTown in townsList)
                {
                    Console.WriteLine($"=>{statTown.Key}: {statTown.Value}");
                }
            }
        }
    }
}
