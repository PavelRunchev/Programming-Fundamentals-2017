using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class ToyShop
    {
        static void Main()
        {
            var priseOfTrip = double.Parse(Console.ReadLine());
            var numberOfPuzzles = double.Parse(Console.ReadLine());
            var numberOfDolls = double.Parse(Console.ReadLine());
            var numberOfTeddyBears = double.Parse(Console.ReadLine());
            var numberOfMinions = double.Parse(Console.ReadLine());
            var numberOfTrucks = double.Parse(Console.ReadLine());

            var pricePuzzles = numberOfPuzzles * 2.60;
            var priceDolls = numberOfDolls * 3.00;
            var priceTeddyBears = numberOfTeddyBears * 4.10;
            var priceMinion = numberOfMinions * 8.20;
            var priceTrucks = numberOfTrucks * 2.00;
            var allPriceForToys = pricePuzzles + priceDolls + priceTeddyBears + priceMinion
                + priceTrucks;
            var quantityToys = numberOfPuzzles + numberOfDolls + numberOfTeddyBears + numberOfMinions
                + numberOfTrucks;
            if(quantityToys >= 50)
            {
                allPriceForToys = allPriceForToys * 0.75;
            }
            var rent = allPriceForToys * 0.10;
            var totalMoneyForTrip = allPriceForToys - rent;
            var leftMoney = Math.Abs(totalMoneyForTrip - priseOfTrip);
            Console.WriteLine(totalMoneyForTrip >= priseOfTrip ? $"Yes! {leftMoney:f2} lv left."
                : $"Not enough money! {leftMoney:f2} lv needed.");
        }
    }
}
