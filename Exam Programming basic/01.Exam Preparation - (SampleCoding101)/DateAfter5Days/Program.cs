using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class Program
    {
        static void Main()
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var days = 31;
            if (month == 2)
            {
                days = 28;
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                days = 30; 
            }
            var sumDay = day + 5;
            var totalDay = 0;
            if(sumDay > days)
            {
                totalDay = Math.Abs(sumDay - days);
            }
            else
            {
                totalDay = sumDay;
            }
            
            if(day + 5 > days)
            {
                month++;
            }
            if(month > 12)
            {
                month = 1;
            }
            if(month < 10)
            {
                Console.WriteLine($"{totalDay}.0{month}");
            }
            else
            {
                Console.WriteLine($"{totalDay}.{month}");
            }

        }
    }
}
