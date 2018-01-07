using System;
using System.Collections.Generic;

namespace ChooseADrink
{
    class ChooseADrink
    {
        static void Main()
        {
            var dataDrink = new Dictionary<string, string>()
            {
                { "Athlete", "Water" },
                { "Businessman", "Coffee" },
                { "Businesswoman", "Coffee" },
                { "SoftUni Student", "Beer" }
            };
            string input = Console.ReadLine();
            Console.WriteLine(dataDrink.ContainsKey(input)? dataDrink[input] : "Tea");
        }
    }
}
