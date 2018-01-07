using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main()
        {
            var priceWhisky = double.Parse(Console.ReadLine());
            var quantityOfBeer = double.Parse(Console.ReadLine());
            var quantityOFWine = double.Parse(Console.ReadLine());
            var quantityOfRakia = double.Parse(Console.ReadLine());
            var quantityOfWhisky = double.Parse(Console.ReadLine());

            var priceRakia = priceWhisky / 2.0;
            var priceWine = priceRakia - (priceRakia * 0.40);
            var priceBeer = priceRakia - (priceRakia * 0.80);
            var needMoneyForAlcohol = (priceWhisky * quantityOfWhisky) + (priceBeer * quantityOfBeer)
                + (priceWine * quantityOFWine) + (priceRakia * quantityOfRakia);
            Console.WriteLine($"{needMoneyForAlcohol:f2}");
        }
    }
}
