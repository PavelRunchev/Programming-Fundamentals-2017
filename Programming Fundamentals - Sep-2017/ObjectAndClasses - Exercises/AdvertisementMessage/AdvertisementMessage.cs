using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main()
        {
            string[] phrases = new string[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            int numberOfLine = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < numberOfLine; i++)
            {
                int indexPhrases = rnd.Next(0, phrases.Length);
                int indexEvents = rnd.Next(0, events.Length);
                int indexAuthors = rnd.Next(0, authors.Length);
                int indexCities = rnd.Next(0, cities.Length);
                Console.WriteLine($"{phrases[indexPhrases]} {events[indexEvents]} {authors[indexAuthors]} - {cities[indexCities]}");
            }
        }
    }
}
