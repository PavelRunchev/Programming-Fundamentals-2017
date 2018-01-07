using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main()
        {
            var dataCreatures = new Dictionary<string, HashSet<string>>();
            string inputCreatures;
            while ((inputCreatures = Console.ReadLine()) != "Blaze it!")
            {
                string[] tokens = inputCreatures
                    .Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
                string creature = tokens[0];
                string squadMate = tokens[1];
                if (creature != squadMate)
                {
                    if (!dataCreatures.ContainsKey(creature))
                    {
                        dataCreatures.Add(creature, new HashSet<string>());
                    }
                    dataCreatures[creature].Add(squadMate);
                }
            }

            var result = new Dictionary<string, List<string>>();

            foreach (var creature in dataCreatures)
            {
                result.Add(creature.Key, new List<string>());

                foreach (var squateMate in creature.Value)
                {
                    if (dataCreatures.ContainsKey(squateMate)
                        && dataCreatures[squateMate].Contains(creature.Key))
                    {
                        continue;
                    }
                    else
                    {
                        result[creature.Key].Add(squateMate);
                    }
                }
            }

            foreach (var item in result.OrderByDescending(d => d.Value.Count()))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
