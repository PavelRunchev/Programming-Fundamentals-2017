using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {           
            Console.WriteLine(DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture).DayOfWeek);
        }
    }
}
