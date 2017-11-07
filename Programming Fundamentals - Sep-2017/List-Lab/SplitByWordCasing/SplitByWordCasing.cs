using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main()
        {
            string[] separators = 
                new string[] { ",", ";", ":", ".", "!", "(", ")",
                    "\"", "'", "\\", "/", "?", "[", "]", " " };
            string[] input = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var lowerList = new List<string>();
            var upperList = new List<string>();
            var mixedList = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                if (word.All(l => l >= 'a' && l <= 'z'))
                {
                    lowerList.Add(word);
                }
                else if (word.All(l => l >= 'A' && l <= 'Z'))
                {
                    upperList.Add(word);
                }
                else
                {
                    mixedList.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerList)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedList)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperList)}");
        }
    }
}
