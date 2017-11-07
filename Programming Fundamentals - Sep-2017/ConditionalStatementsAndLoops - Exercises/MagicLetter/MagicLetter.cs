using System;

namespace MagicLetter
{
    class MagicLetter
    {
        static void Main()
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var thirdtLetter = char.Parse(Console.ReadLine());

            for (var letter1 = firstLetter; letter1 <= secondLetter; letter1++)
            {
                for (char letter2 = firstLetter; letter2 <= secondLetter; letter2++)
                {
                    for (char letter3 = firstLetter; letter3 <= secondLetter; letter3++)
                    {
                        if (letter1 != thirdtLetter && letter2 != thirdtLetter && letter3 != thirdtLetter)
                        {
                            Console.Write($"{letter1}{letter2}{letter3}" + " ");
                        }                    
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
