using System;
using System.Collections.Generic;

namespace MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            HashSet<char> word1 = new HashSet<char>(input[0]);
            HashSet<char> word2 = new HashSet<char>(input[1]);
            bool isExchangeable = word1.Count == word2.Count;
            Console.WriteLine(isExchangeable ? "true" : "false");
        }
    }
}
