using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            var dataMiners = new Dictionary<string, long>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                long quantity = long.Parse(Console.ReadLine());
                
                if (!dataMiners.ContainsKey(input))
                {
                    dataMiners.Add(input, 0L);
                }
                dataMiners[input] += quantity;
            }

            foreach (var miner in dataMiners)
            {
                Console.WriteLine($"{miner.Key} -> {miner.Value}");
            }
        }
    }
}
