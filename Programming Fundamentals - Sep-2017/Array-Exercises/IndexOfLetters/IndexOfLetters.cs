using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            string[] dataAllLetters = new string[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                "k", "l", "m", "n", "o", "p", "q", "r", "s",
                "t", "u", "v", "w", "x", "y", "z"
            };

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                string letter = text[i].ToString();
                int index = Array.IndexOf(dataAllLetters, letter);
                Console.WriteLine($"{letter} -> {index}");
            }
        }
    }
}
