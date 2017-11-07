using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            string[] weeks =
            {
                "Monday", "Tuesday", "Wednesday", "Thursday",
                "Friday", "Saturday", "Sunday"
            };

            var day = int.Parse(Console.ReadLine());
            Console.WriteLine(day >= 1 && day <= 7 ? weeks[day - 1] : "Invalid Day!");
        }
    }
}
