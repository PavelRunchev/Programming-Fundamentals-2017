using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hideout
{
    class Hideout
    {
        static void Main()
        {
            string inputMap = Console.ReadLine();

            while (true)
            {
                string[] inputClues = Console.ReadLine().Split(' ');
                string patern = $@"\{inputClues[0]}{{{inputClues[1]},}}";
                Match regex = Regex.Match(inputMap, patern);
                if (regex.Success)
                {
                    Console.WriteLine($"Hideout found at index {inputMap.IndexOf(regex.Value)} and it is with size {regex.Value.Length}!");
                    break;
                }
            }    
        }
    }
}
