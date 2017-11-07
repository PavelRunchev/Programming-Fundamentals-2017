using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main()
        {
            var time = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            int hours = time[0];
            int minutes = time[1];
            int seconds = time[2];
            var numberOfStep = BigInteger.Parse(Console.ReadLine());
            var timeOfSecond = BigInteger.Parse(Console.ReadLine());
            BigInteger timeInSeconds = seconds + (minutes * 60) + (hours * 60 * 60);
            BigInteger allseconds = timeInSeconds + (numberOfStep * timeOfSecond);
            BigInteger hour = (allseconds / 3600) % 24;
            BigInteger minute = (allseconds / 60) % 60;
            BigInteger second = allseconds % 60;

            Console.WriteLine($"Time Arrival: {hour:d2}:{minute:d2}:{second:d2}");
        }
    }
}
