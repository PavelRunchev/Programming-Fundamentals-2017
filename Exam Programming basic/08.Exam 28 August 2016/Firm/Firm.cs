using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm
    {
        static void Main()
        {
            var needHours = int.Parse(Console.ReadLine());
            var firmDays = int.Parse(Console.ReadLine());
            var personal = int.Parse(Console.ReadLine());

            var hoursForWork = (firmDays * 0.90) * 8;
            var specialWork = personal * (firmDays * 2);
            var allHours = Math.Floor(hoursForWork + specialWork);
            var leftHours = Math.Abs(allHours - needHours);
            Console.WriteLine(allHours >= needHours ? $"Yes!{leftHours} hours left." 
                : $"Not enough time!{leftHours} hours needed.");
        }
    }
}
