using System;

namespace WordInPlural
{
    class WordInPlural
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string plural = string.Empty;


            if (word.EndsWith("y"))
            {
                string delleteEndLetter = word.Remove(word.Length - 1);
                plural = delleteEndLetter + "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("s") 
                || word.EndsWith("x") || word.EndsWith("z")
                || word.EndsWith("ch") || word.EndsWith("sh"))
            {
                plural = word + "es";
            }
            else
            {
                plural = word + "s";
            }

            Console.WriteLine(plural);
        }
    }
}
