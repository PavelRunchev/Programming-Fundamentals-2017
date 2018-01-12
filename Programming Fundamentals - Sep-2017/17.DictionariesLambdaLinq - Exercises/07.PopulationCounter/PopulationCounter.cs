using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main()
        {
             var dataPopulations = new Dictionary<string, Dictionary<string, long>>();
            string input;
            while((input = Console.ReadLine()) != "report")
            {
                string[] tokens = input.Split('|');
                string country = tokens[1];
                string city = tokens[0];
                long population = long.Parse(tokens[2]);
                if (!dataPopulations.ContainsKey(country))
                {
                    dataPopulations.Add(country, new Dictionary<string, long>());
                }
                if (!dataPopulations[country].ContainsKey(city))
                {
                    dataPopulations[country].Add(city, 0);
                }
                dataPopulations[country][city] = population;
            }

            foreach (var country in dataPopulations.OrderByDescending(pop => pop.Value.Values.Sum()))
            {
                long totalPopulation = country.Value.Values.Sum();
                Console.WriteLine($"{country.Key} (total population: {totalPopulation})");
                foreach (var city in country.Value.OrderByDescending(town => town.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
