using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            var worksDay = int.Parse(Console.ReadLine());
            var cashForDay = decimal.Parse(Console.ReadLine());
            var exchangeDollar = decimal.Parse(Console.ReadLine());

            var monthSalary = worksDay * cashForDay;
            var annualIncomeInDollars = (monthSalary * 12) + (monthSalary * 2.5m);
            var commission = annualIncomeInDollars * 0.75m;
            var totalIncomeInLeva = commission * exchangeDollar;
            var middleIncomeForDay = totalIncomeInLeva / 365;

            Console.WriteLine($"{middleIncomeForDay:f2}");
        }
    }
}
