using System;
using System.Collections.Generic;

namespace MonthPrinter
{
    class MonthPrinter
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            string[] months = new string[]
            {
                "January", "February", "March", "April", "May",
                "June", "July", "August", "September",
                "October", "November", "December"
            };
            try
            {
                Console.WriteLine(months[day - 1]);
            }
            catch
            {
                Console.WriteLine("Error!");
            }          
        }
    }
}
