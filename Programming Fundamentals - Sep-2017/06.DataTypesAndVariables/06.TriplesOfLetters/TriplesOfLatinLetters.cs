using System;

namespace TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (char letter1 = 'a'; letter1 < 'a' + n; letter1++)
            {
                for (int letter2 = 'a'; letter2 < 'a' + n; letter2++)
                {
                    for (int letter3 = 'a'; letter3 < 'a' + n; letter3++)
                    {
                        Console.WriteLine($"{(char)letter1}{(char)letter2}{(char)letter3}");
                    }
                }
            }
        }
    }
}
