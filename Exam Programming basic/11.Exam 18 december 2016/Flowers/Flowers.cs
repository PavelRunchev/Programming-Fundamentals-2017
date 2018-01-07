using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main()
        {
            var numberChrysanthemum = int.Parse(Console.ReadLine());
            var numberRose = int.Parse(Console.ReadLine());
            var numberTulip = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holiday = Console.ReadLine();

            var priceChrysanthemum = 0.0;
            var priceRose = 0.0;
            var priceTulip = 0.0;
            switch(season)
            {
                case "Spring":                  
                case "Summer": priceChrysanthemum = 2.00;
                    priceRose = 4.10;
                    priceTulip = 2.50;
                    break; 

                case "Autumn": 
                case "Winter":
                    priceChrysanthemum = 3.75;
                    priceRose = 4.50;
                    priceTulip = 4.15;
                    break;
            }
            var priceFlowers = (numberChrysanthemum * priceChrysanthemum)
                + (numberRose * priceRose) + (numberTulip * priceTulip);
            if(holiday == "Y")
            {
                priceFlowers = priceFlowers + (priceFlowers * 0.15);
            }
            if(numberTulip > 7 && season == "Spring")
            {
                priceFlowers = priceFlowers * 0.95;
            }
            if(numberRose >= 10 && season == "Winter")
            {
                priceFlowers = priceFlowers * 0.90;
            }
            var numberFlawers = numberChrysanthemum + numberRose + numberTulip;
            if(numberFlawers > 20)
            {
                priceFlowers = priceFlowers * 0.80;
            }
            var totalPrice = priceFlowers + 2;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
