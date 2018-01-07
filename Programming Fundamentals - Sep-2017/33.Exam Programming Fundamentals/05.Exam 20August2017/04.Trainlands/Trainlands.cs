using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainlands
{
    class Trainlands
    {
        static void Main()
        {
            var dataTrains = new Dictionary<string, Dictionary<string, int>>();
            string inputTrains;
            while ((inputTrains = Console.ReadLine()) != "It's Training Men!")
            {
                string[] tokensTrains = inputTrains
                    .Split(new string[] { " -> ", " : ", " = " },
                    StringSplitOptions.RemoveEmptyEntries);
                string trainName = tokensTrains[0];
                if(tokensTrains.Length == 2)
                {
                    string otherTrainName = tokensTrains[1];
                    if(inputTrains.Contains(" -> "))
                    {
                        if (!dataTrains.ContainsKey(trainName))
                        {
                            dataTrains.Add(trainName, new Dictionary<string, int>());
                        }

                        foreach (var wagon in dataTrains[otherTrainName])
                        {
                            dataTrains[trainName].Add(wagon.Key, wagon.Value);
                        }
                        dataTrains.Remove(otherTrainName);
                    }
                    else if(inputTrains.Contains(" = "))
                    {
                        if (!dataTrains.ContainsKey(trainName))
                        {
                            dataTrains.Add(trainName, new Dictionary<string, int>());
                        }
                        else
                        {
                            dataTrains[trainName].Clear();
                        }

                        foreach (var wagon in dataTrains[otherTrainName])
                        {
                            dataTrains[trainName].Add(wagon.Key, wagon.Value);
                        }
                    }
                }
                else if(tokensTrains.Length == 3)
                {
                    string wagonName = tokensTrains[1];
                    int wagonPower = int.Parse(tokensTrains[2]);
                    if (!dataTrains.ContainsKey(trainName))
                    {
                        dataTrains.Add(trainName, new Dictionary<string, int>());
                    }
                    if (!dataTrains[trainName].ContainsKey(wagonName))
                    {
                        dataTrains[trainName].Add(wagonName, 0);
                    }
                    dataTrains[trainName][wagonName] = wagonPower;
                }
            }

            PrintAllTrains(dataTrains);
        }

        private static void PrintAllTrains(Dictionary<string, Dictionary<string, int>> dataTrains)
        {
            var orderedTrainsByWagonPower = dataTrains
                .OrderByDescending(p => p.Value.Values.Sum())
                .ThenBy(c => c.Value.Count())
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var train in orderedTrainsByWagonPower)
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagon in train.Value.OrderByDescending(w => w.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
