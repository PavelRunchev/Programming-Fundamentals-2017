using System;
using System.Collections.Generic;
using System.Linq;

namespace VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int num;
            if(int.TryParse(input, out num))
            {
                Console.WriteLine("digit");
            }
            else if(input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }         
        }
    }
}
