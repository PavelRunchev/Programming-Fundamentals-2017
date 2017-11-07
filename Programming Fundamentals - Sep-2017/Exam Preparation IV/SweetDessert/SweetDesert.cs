using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDesert
    {
        static void Main()
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            long numberOfGuests = long.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBerries = decimal.Parse(Console.ReadLine());

            var set = Math.Ceiling(numberOfGuests / 6.0m);
            decimal needProducts = set * (2 * priceOfBananas) + set * (4 * priceOfEggs) + set * (0.2m * priceOfBerries); 
            if(needProducts <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {needProducts:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {needProducts - amountOfCash:f2}lv more.");
            }
        }
    }
}
