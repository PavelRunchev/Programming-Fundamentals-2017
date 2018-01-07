using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPrize
{
    class MoneyPrize
    {
        static void Main()
        {
            var project = int.Parse(Console.ReadLine());
            var moneyPrize = double.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= project; i++)
            {
                var point = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum += point * 2;
                }
                else
                {
                    sum += point;
                }

            }
            Console.WriteLine($"The project prize was {sum * moneyPrize:f2} lv.");
        }
    }
}
