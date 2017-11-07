using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main()
        {
            DateTime time = DateTime
                .ParseExact(Console.ReadLine(), "HH:mm:ss",
                CultureInfo.InvariantCulture);
            var numberOfSteps = ulong.Parse(Console.ReadLine()) % 86400;
            var timeInSeconds = ulong.Parse(Console.ReadLine()) % 86400;

            ulong stepsInSeconds = numberOfSteps * timeInSeconds;
            TimeSpan allseconds = TimeSpan.FromSeconds(stepsInSeconds);
            Console.WriteLine($"Time Arrival: {time.Add(allseconds).ToString("HH:mm:ss")}");
        }
    }
}
