using System;
using System.Collections.Generic;
using System.Linq;

namespace MelrahShake
{
    class MelrahShake
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var key = Console.ReadLine();

            while (true)
            {
                int firstKey = text.IndexOf(key);
                int lastKey = text.LastIndexOf(key);
                bool keyIsEmpty = key != string.Empty;
                bool isEqual = firstKey != lastKey;
                bool isIndexFirstKey = firstKey != -1;
                bool isIndexLastKey = lastKey != -1;
                if (isEqual && keyIsEmpty && isIndexFirstKey && isIndexLastKey)
                {
                    text = text.Remove(lastKey, key.Length);
                    text = text.Remove(firstKey, key.Length);
                    Console.WriteLine("Shaked it.");
                    key = key.Remove(key.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    break;
                }
            }
        }
    }
}
