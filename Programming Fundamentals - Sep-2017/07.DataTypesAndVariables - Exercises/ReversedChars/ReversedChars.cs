using System;
using System.Collections.Generic;
using System.Linq;

namespace ReversedChars
{
    class ReversedChars
    {
        static void Main()
        {
            char[] array = new char[3];
            for (int i = 0; i < array.Length; i++)
            {
                char input = char.Parse(Console.ReadLine());
                array[i] = input;
            }
            Array.Reverse(array);
            Console.WriteLine(string.Join("", array));
        }
    }
}
