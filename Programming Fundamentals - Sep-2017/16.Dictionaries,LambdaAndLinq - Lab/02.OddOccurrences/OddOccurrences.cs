using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            var dataoddNumbersWords = new Dictionary<string, int>();
            var input = Console.ReadLine().ToLower().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                if (!dataoddNumbersWords.ContainsKey(word))
                {
                    dataoddNumbersWords.Add(word, 0);
                }
                dataoddNumbersWords[word]++;
            }

            List<string> oddCountsWords = dataoddNumbersWords
                .Where(l => l.Value % 2 != 0)
                .Select(word => word.Key)
                .ToList();

            Console.WriteLine(string.Join(", ", oddCountsWords));
        }
    }
}
