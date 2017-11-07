using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCount
    {
        static void Main()
        {
            var dataWordCounts = new Dictionary<string, int>();
            string[] input = File.ReadAllText(@"..\..\text.txt")
                .ToLower()
                .Split(new char[] { ' ', ',', '-', '.', '!', '?', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries);
            string[] words = File.ReadAllText("..\\..\\words.txt").ToLower().Split();
            foreach (var word in input)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    string searchWord = words[i];
                    if (searchWord == word)
                    {
                        if (!dataWordCounts.ContainsKey(word))
                        {
                            dataWordCounts.Add(word, 0);
                        }
                        dataWordCounts[word]++;
                    }
                }
            }

            File.WriteAllText(@"..\..\result.txt", "");

            var orderedCountsWords = dataWordCounts
                .OrderByDescending(count => count.Value);
            foreach (var wordAndCount in orderedCountsWords)
            {
                File.AppendAllText(@"..\..\result.txt", wordAndCount.Key + " - " + wordAndCount.Value + Environment.NewLine);
            }          
        }
    }
}
