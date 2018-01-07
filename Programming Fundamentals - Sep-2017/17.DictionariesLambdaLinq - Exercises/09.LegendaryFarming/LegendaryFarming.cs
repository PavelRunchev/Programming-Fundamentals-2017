using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main()
        {
            var dataItems = new Dictionary<string, string>
            {
                { "shards", "Shadowmourne" },
                { "fragments", "Valanyr" },
                { "motes", "Dragonwrath" }
            };
            var dataUniqueItems = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            };
            var dataJunk = new Dictionary<string, int>();

            bool isObtained = false;
            string[] input = Console.ReadLine().ToLower().Split(' ');
            while(true)
            {
                for (int i = 0; i < input.Length; i+= 2)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1];
                    if (dataItems.ContainsKey(item))
                    {
                        dataUniqueItems[item] += quantity;
                        if (dataUniqueItems[item] >= 250)
                        {
                            Console.WriteLine($"{dataItems[item]} obtained!");
                            dataUniqueItems[item] -= 250;
                            isObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!dataJunk.ContainsKey(item))
                        {
                            dataJunk.Add(item, 0);
                        }
                        dataJunk[item] += quantity;
                    }
                }            

                if(isObtained)
                {
                    break;
                }
                input = Console.ReadLine().ToLower().Split(' ');
            }

            var orderedUniqueItems = dataUniqueItems
                .OrderBy(x => x.Key)
                .OrderByDescending(a => a.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            var orderedJunkItems = dataJunk
                .OrderBy(s => s.Key)
                .ToDictionary(c => c.Key, x => x.Value);

            foreach (var uniqueItems in orderedUniqueItems)
            {
                Console.WriteLine($"{uniqueItems.Key}: {uniqueItems.Value}");
            }

            foreach (var items in orderedJunkItems)
            {
                Console.WriteLine($"{items.Key}: {items.Value}");
            }
        }
    }
}
