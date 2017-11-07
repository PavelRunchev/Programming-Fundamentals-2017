using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            string firstString = input[0];
            string secondString = input[1];
            int minLen = Math.Min(firstString.Length, secondString.Length);
            long sumCharacters = 0;
            for (int i = 0; i < minLen; i++)
            {
                char letter1 = firstString[i];
                char letter2 = secondString[i];
                sumCharacters += (int)letter1 * (int)letter2;
            }

            int maxLen = Math.Max(firstString.Length, secondString.Length);
            for (int j = minLen; j < maxLen; j++)
            {
                if (firstString.Length > secondString.Length)
                {
                    sumCharacters += (int)firstString[j];
                }
                else
                {
                    sumCharacters += (int)secondString[j];
                }
            }
            Console.WriteLine(sumCharacters);
        }
    }
}
