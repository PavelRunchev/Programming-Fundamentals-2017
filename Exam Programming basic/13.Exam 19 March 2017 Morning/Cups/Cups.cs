using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Cups
    {
        static void Main()
        {
            var needNumberOfCups = int.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());
            var workerDays = int.Parse(Console.ReadLine());

            var needHours = numberOfWorkers * workerDays * 8;
            var numberOfCups = Math.Floor(needHours / 5.0);
          
            var leftMoney = Math.Abs(numberOfCups - needNumberOfCups);
            Console.WriteLine(numberOfCups >= needNumberOfCups ? $"{leftMoney * 4.20:f2} extra money" 
                : $"Losses: {leftMoney * 4.20:f2}");
        }
    }
}
