using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main()
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var juan = decimal.Parse(Console.ReadLine());
            var commission = decimal.Parse(Console.ReadLine());
            var euro = 1.95m;
            var dollar = 1.76m;

            var changeBitcoinInLeva = bitcoin * 1168;
            var changeJuanInLeva = (juan * 0.15m) * dollar;
            var allSumLeva = changeBitcoinInLeva + changeJuanInLeva;
            var changeInEuro = allSumLeva / euro;
            var totalSum = changeInEuro - (changeInEuro * (commission / 100));
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
