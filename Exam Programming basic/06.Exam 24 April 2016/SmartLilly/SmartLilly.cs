using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class SmartLilly
    {
        static void Main()
        {
            var ageLilly = int.Parse(Console.ReadLine());
            var priceWashingMachine = double.Parse(Console.ReadLine());
            var priceToy = int.Parse(Console.ReadLine());

            var brother = 0;
            var money = 0;
            var toy = 0;
            var sum = 0;
            for (int i = 1; i <= ageLilly; i++)
            {
                if(i % 2 == 0)
                {
                    sum += 10;
                    brother++;
                    money += sum;
                }
                if(i % 2 != 0)
                {
                    toy++;
                }
            }
            var cellToy = toy * priceToy;
            var getMoneyFromLilly = brother * 1;
            var remainingMoney = money + cellToy - getMoneyFromLilly;

            var left = Math.Abs(priceWashingMachine - remainingMoney);
            Console.WriteLine(remainingMoney >= priceWashingMachine ?
                $"Yes! {left:f2}" : $"No! {left:f2}");
        }
    }
}
