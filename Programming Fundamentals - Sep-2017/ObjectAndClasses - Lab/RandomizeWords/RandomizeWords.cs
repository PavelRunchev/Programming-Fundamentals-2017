using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            Random random = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                int position = random.Next(0, input.Length - 1);
                string nextWord = input[position];

                input[i] = nextWord;
                input[position] = currentWord;
            }

            Console.WriteLine(string.Join("\r\n", input));
        }
    }
}
