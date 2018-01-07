using System;
using System.Collections.Generic;
using System.Linq;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            foreach (var @char in input)
            {
                Console.Write($"\\u{(int)@char:x4}");
            }
            Console.WriteLine();
        }
    }
}
