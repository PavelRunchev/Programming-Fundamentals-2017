using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main()
        {
            var numberWeekend = int.Parse(Console.ReadLine());

            var weekendMinute = numberWeekend * 127;
            var workDayMinute = (365 - numberWeekend) * 63;
            var allMinutePlay = weekendMinute + workDayMinute;
            var leftMinutePlay = Math.Abs(30000 - allMinutePlay);

            var hours = leftMinutePlay / 60;
            var minutes = leftMinutePlay % 60;

            if(allMinutePlay <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }          
        }
    }
}
