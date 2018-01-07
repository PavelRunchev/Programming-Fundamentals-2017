using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign
{
    class CharityCampaign
    {
        static void Main()
        {
            var numberOfDays = int.Parse(Console.ReadLine());
            var numberOfConfectioner = int.Parse(Console.ReadLine());
            var numberOfCakes = int.Parse(Console.ReadLine());
            var numberOfWafers = int.Parse(Console.ReadLine());
            var numberOfPancakes = int.Parse(Console.ReadLine());

            var priceCakes = numberOfCakes * 45;
            var priceWafers = numberOfWafers * 5.80;
            var pricePancakes = numberOfPancakes * 3.20;
            var sumOfDay = (priceCakes + pricePancakes + priceWafers) * numberOfConfectioner;
            var allSumOfCampaign = sumOfDay * numberOfDays;
            var tax = allSumOfCampaign / 8.0;
            var sumAfterTax = allSumOfCampaign - tax;
            Console.WriteLine($"{sumAfterTax:f2}");
        }
    }
}
