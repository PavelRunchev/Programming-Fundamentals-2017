using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class HornetWings
    {
        static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distancePerMeters = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());
            double distance = (wingFlaps / 1000) * distancePerMeters;
            long hornetFlapsPerSeconds = wingFlaps / 100;
            var timeOfseconds = ((wingFlaps / endurance) * 5) + hornetFlapsPerSeconds;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{timeOfseconds} s.");
        }
    }
}
