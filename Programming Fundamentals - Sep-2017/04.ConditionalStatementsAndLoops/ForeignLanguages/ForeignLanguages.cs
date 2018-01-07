using System;
using System.Collections.Generic;

namespace ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var data = new Dictionary<string, string>();
            data.Add("USA", "English");
            data.Add("England", "English");
            data.Add("Spain", "Spanish");
            data.Add("Argentina", "Spanish");
            data.Add("Mexico", "Spanish");
            Console.WriteLine(data.ContainsKey(input) ? data[input] : "unknown");
        }
    }
}
