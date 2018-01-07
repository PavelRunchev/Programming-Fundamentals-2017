using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main()
        {
            var firstSpeedInHour = int.Parse(Console.ReadLine());
            var firstTimeInMinutes = int.Parse(Console.ReadLine());
            var secondTimeInMinutes = int.Parse(Console.ReadLine());
            var thirdTimeInMinutes = int.Parse(Console.ReadLine());

            var firstSpeed = firstSpeedInHour * (firstTimeInMinutes / 60.0);

            var afterIncrease = firstSpeedInHour + (firstSpeedInHour * 0.10);
            var afterIncreaseInHour = afterIncrease * (secondTimeInMinutes / 60.0);

            var afterReduction = afterIncrease - (afterIncrease * 0.05);
            var afterReductionInHour = afterReduction * (thirdTimeInMinutes / 60.0);

            var allDistance = firstSpeed + afterIncreaseInHour + afterReductionInHour;
            Console.WriteLine($"{allDistance:f2}");
        }
    }
}
