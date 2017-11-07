using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Legion
    {
        public long LastActivity { get; set; }
        public string Name { get; set; }
        public Dictionary<string, long> Solders { get; set; }
    }
    class HornetArmada
    {
        static void Main()
        {
            List<Legion> dataLegions = new List<Legion>();
            long countOfLine = long.Parse(Console.ReadLine());
            for (int i = 0; i < countOfLine ; i++)
            {
                string[] inputLegion = Console.ReadLine()
                    .Split(new string[] { " = ", " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
                long lastActivity = long.Parse(inputLegion[0]);
                string name = inputLegion[1];

                string tokens = inputLegion[2];
                int index = tokens.LastIndexOf(":");
                string type = tokens.Substring(0, index);
                long count = long.Parse(tokens.Substring(index + 1));

                if (!dataLegions.Any(a => a.Name == name))
                {
                    Legion legion = new Legion();
                    legion.Name = name;
                    legion.LastActivity = lastActivity;
                    legion.Solders = new Dictionary<string, long>();
                    legion.Solders.Add(type, count);
                    dataLegions.Add(legion);
                }
                else
                {
                    if (dataLegions.Any(a => a.Name == name))
                    {
                        var currentLegion = dataLegions.FirstOrDefault(x => x.Name == name);
                        if(!currentLegion.Solders.ContainsKey(type))
                        {
                            if(currentLegion.LastActivity < lastActivity)
                            {
                                currentLegion.LastActivity = lastActivity;
                            }
                            currentLegion.Solders.Add(type, count);
                        }
                        else
                        {
                            if (currentLegion.LastActivity < lastActivity)
                            {
                                currentLegion.LastActivity = lastActivity;
                            }
                            currentLegion.Solders[type] += count;
                        }
                    }
                }
            }
            SecondPart(dataLegions);
        }

        private static void SecondPart(List<Legion> dataLegions)
        {
            string searchSolder = Console.ReadLine();
            int index = searchSolder.IndexOf("\\");
            if (index != -1)
            {
                long searchLastActivity = long.Parse(searchSolder.Substring(0, index));
                string searchSolderType = searchSolder.Substring(index + 1);
                List<Legion> allLegions = dataLegions
                    .Where(g => g.LastActivity < searchLastActivity)
                    .ToList();
                var resultTypeAndCountLegions = new Dictionary<string, long>();
                foreach (var legion in allLegions)
                {
                    string name = legion.Name;
                    foreach (var sodrierAndCount in legion.Solders)
                    {
                        if(searchSolderType == sodrierAndCount.Key)
                        {
                            resultTypeAndCountLegions.Add(name, sodrierAndCount.Value);
                        }
                    }
                }

                foreach (var item in resultTypeAndCountLegions.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
            else
            {
                var legions = dataLegions.Where(f => f.Solders.Keys.Contains(searchSolder))
                    .OrderByDescending(d => d.LastActivity).ToList();
                foreach (var item in legions)
                {
                    Console.WriteLine($"{item.LastActivity} : {item.Name}");
                }
            }
        }
    }
}
