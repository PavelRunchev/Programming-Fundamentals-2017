using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = new[]
            {
                "01-01-1970",
                "03-03-1970",
                "01-05-1970",
                "06-05-1970",
                "24-05-1970",
                "06-09-1970",
                "22-09-1970",
                "01-11-1970",
                "24-12-1970",
                "25-12-1970",
                "26-12-1970",
            }
            .Select(d => DateTime.ParseExact(d, "dd-MM-yyyy", CultureInfo.InvariantCulture))
            .ToList();

            int countOfWorkingDays = 0;
            for (DateTime currentDate = startDate; currentDate <= endDate;
                currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday 
                    && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool isHolidays = holidays
                        .Any(d => d.Day == currentDate.Day && d.Month == currentDate.Month);
                    
                    if (!isHolidays)
                    {
                        countOfWorkingDays++;
                    }                   
                }
            }

            Console.WriteLine(countOfWorkingDays);
        }
    }
}
