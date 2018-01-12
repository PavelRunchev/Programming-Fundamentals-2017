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
       		var dataJunks = new Dictionary<string, int>();
            var dataLegendaryItem = new Dictionary<string, int> {
                {"shards", 0 },
                {"fragments", 0 },
                {"motes", 0 }
            };

            bool obtained = false;
            while (true)
            {
                string[] inputMaterials = Console.ReadLine().ToLower().Split(' ');
                for (int i = 0; i < inputMaterials.Length; i += 2)
                {
                    int qunatity = int.Parse(inputMaterials[i]);
                    string material = inputMaterials[i + 1];
                    if (dataLegendaryItem.ContainsKey(material))
                    {
                        dataLegendaryItem[material] += qunatity;
                        if (dataLegendaryItem[material] >= 250)
                        {

                            if (material == "shards")
                            {
                                dataLegendaryItem[material] -= 250;
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "fragments")
                            {
                                dataLegendaryItem[material] -= 250;
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "motes")
                            {
                                dataLegendaryItem[material] -= 250;
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            obtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!dataJunks.ContainsKey(material))
                        {
                            dataJunks.Add(material, 0);
                        }
                        dataJunks[material] += qunatity;
                    }
                }

                if (obtained)
                    break;
            }

            foreach (var legendaryItem in dataLegendaryItem.OrderByDescending(q => q.Value).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{legendaryItem.Key}: {legendaryItem.Value}");
            }

            foreach (var junk in dataJunks.OrderBy(j => j.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
