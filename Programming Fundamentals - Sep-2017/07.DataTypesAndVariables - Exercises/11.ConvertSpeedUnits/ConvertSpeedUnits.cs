using System;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            var distanceInMeters = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            float meterPerSeconds = (float)(distanceInMeters) / (seconds + (minutes * 60) + (hours * 3600));
            float kilometersPerHour = (distanceInMeters / 1000f) / ((seconds / 3600f) + (minutes / 60f) + hours);
            float milesPerHour = (distanceInMeters / 1609f) / ((seconds / 3600f) + (minutes / 60f) + hours);
            Console.WriteLine(meterPerSeconds);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
