using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class FlowerShop
    {
        static void Main()
        {
            var numberMagnolia = int.Parse(Console.ReadLine());
            var numberHyacinth = int.Parse(Console.ReadLine());
            var numberRose = int.Parse(Console.ReadLine());
            var numberCactus = int.Parse(Console.ReadLine());
            var pricePresent = double.Parse(Console.ReadLine());

            double priceFlowers = (numberMagnolia * 3.25) + (numberHyacinth * 4.00)
                + (numberRose * 3.50) + (numberCactus * 8.00);
            var commission = priceFlowers * 0.05;
            double totalPrice = priceFlowers - commission;

            var leftLeva = Math.Floor(totalPrice - pricePresent);
            var notEnoughMoney = Math.Ceiling(pricePresent - totalPrice);

            Console.WriteLine(totalPrice >= pricePresent ? $"She is left with {leftLeva} leva." 
                : $" She will have to borrow {notEnoughMoney} leva.");
        }
    }
}
