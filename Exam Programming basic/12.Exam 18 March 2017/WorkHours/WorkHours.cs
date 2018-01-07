using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours
{
    class WorkHours
    {
        static void Main()
        {
            var needHours = int.Parse(Console.ReadLine());
            var numbersWorkers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var workHours = numbersWorkers * workDays * 8;
            var left = Math.Abs(workHours - needHours);
            if(workHours >= needHours)
            {
                Console.WriteLine($"{left} hours left");
            }
            else
            {
                Console.WriteLine($"{left} overtime");
                Console.WriteLine($"Penalties: {left * workDays}");
            }
        }
    }
}
