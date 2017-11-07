using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main()
        {           
            int[] input = File.ReadLines(@"..\..\input.txt")
                .Select(a => int.Parse(a.ToString()))
                .ToArray();
            int numberOfLine = input[0];
            string[] phrases = File.ReadAllLines(@"..\..\Phrases.txt");
            string[] events = File.ReadAllLines(@"..\..\Events.txt");
            string[] authors = File.ReadAllLines(@"..\..\Authors.txt");
            string[] cities = File.ReadAllLines(@"..\..\Cities.txt");

            Random rnd = new Random();
            File.WriteAllText(@"..\..\output.txt", string.Empty);
            for (int i = 0; i < numberOfLine; i++)
            {
                int phraseIndex = rnd.Next(0, phrases.Length);
                int eventIndex = rnd.Next(0, events.Length);
                int autorIndex = rnd.Next(0, authors.Length);
                int cityIndex = rnd.Next(0, cities.Length);

                string randomAppend = $"{phrases[phraseIndex]} {events[eventIndex]} {authors[autorIndex]} - {cities[cityIndex]}"
                    + Environment.NewLine;
                File.AppendAllText(@"..\..\output.txt", randomAppend);
            }
        }
    }
}
