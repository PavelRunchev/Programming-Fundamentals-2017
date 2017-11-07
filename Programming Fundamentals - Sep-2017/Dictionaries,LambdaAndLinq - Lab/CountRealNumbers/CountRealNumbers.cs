using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            var dataNumbers = new Dictionary<double, int>();
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                double number = input[i];
                if (!dataNumbers.ContainsKey(number))
                {
                    dataNumbers.Add(number, 0);
                }
                dataNumbers[number]++;
            }

            var orderedNumbers = dataNumbers
                .OrderBy(n => n.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var numberAndCount in orderedNumbers)
            {
                double number = numberAndCount.Key;
                int count = numberAndCount.Value;
                Console.WriteLine("{0} -> {1}", number, count);
            }
        }
    }
}
