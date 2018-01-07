using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class AnonymousCache
    {
        static void Main()
        {
            var datacache = new Dictionary<string, Dictionary<string, long>>();
            var data = new Dictionary<string, Dictionary<string, long>>();
            string input;
            string dataSet;
            long size;
            string key;
            while ((input = Console.ReadLine()) != "thetinggoesskrra")
            {
                string[] tokens = input
                    .Split(new char[] { ' ', '-', '>', '|' },
                    StringSplitOptions.RemoveEmptyEntries);
                if(tokens.Length > 1)
                {
                    dataSet = tokens[2];
                    size = long.Parse(tokens[1]);
                    key = tokens[0];
                    if (data.ContainsKey(dataSet))
                    {
                        if (!data[dataSet].ContainsKey(key))
                        {
                            data[dataSet].Add(key, 0);
                        }
                        data[dataSet][key] += size;
                    }
                    else
                    {
                        if (!datacache.ContainsKey(dataSet))
                        {
                            datacache.Add(dataSet, new Dictionary<string, long>());
                        }
                        if (!datacache[dataSet].ContainsKey(key))
                        {
                            datacache[dataSet].Add(key, 0);
                        }
                        datacache[dataSet][key] += size;
                    }
                }
                else
                {
                    dataSet = tokens[0];
                    if (!data.ContainsKey(dataSet) && !datacache.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }
                    else
                    {
                        if (datacache.ContainsKey(dataSet))
                        {
                            var currentSet = datacache.FirstOrDefault(a => a.Key == dataSet);
                            if (!data.ContainsKey(dataSet))
                            {
                                data.Add(dataSet, new Dictionary<string, long>());
                            }
                            if (!data[dataSet].ContainsKey(currentSet.Key))
                            {
                                data[dataSet] = currentSet.Value;
                            }
                        }
                    }
                }
            }

            PrintDataSet(data);
        }

        private static void PrintDataSet(Dictionary<string, Dictionary<string, long>> data)
        {
            if(data.Count == 0)
            {
                return;
            }
            var sortedBySize = data
                .OrderByDescending(f => f.Value.Values.Sum())
                .ToDictionary(w => w.Key, v => v.Value);
  
            List<string> dataKeyList = sortedBySize.First().Value.Keys.ToList();
            string dataSet = sortedBySize.First().Key;
            long size = sortedBySize.First().Value.Values.Sum();
            Console.WriteLine($"Data Set: {dataSet}, Total Size: {size}");
            foreach (var key in dataKeyList)
            {
                Console.WriteLine($"$.{key}");
            }
        }
    }
}
