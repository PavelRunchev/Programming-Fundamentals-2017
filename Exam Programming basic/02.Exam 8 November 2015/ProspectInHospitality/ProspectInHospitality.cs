using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectInHospitality
{
    class ProspectInHospitality
    {
        static void Main()
        {
            var neededBuiliders = uint.Parse(Console.ReadLine());
            var neededReceptionists = uint.Parse(Console.ReadLine());
            var neededChambermaids = uint.Parse(Console.ReadLine());
            var neededTechnicians = uint.Parse(Console.ReadLine());
            var neededOthers = uint.Parse(Console.ReadLine());

            var NikiSalaryInUSD = decimal.Parse(Console.ReadLine());
            var currencyRateUSA = decimal.Parse(Console.ReadLine());
            var yourSalary = decimal.Parse(Console.ReadLine());
            var budget = decimal.Parse(Console.ReadLine());

            var pricePersonal = (neededBuiliders * 1500.04) + (neededReceptionists * 2102.10)
                + (neededChambermaids * 1465.46) + (neededTechnicians * 2053.33)
                + (neededOthers * 3010.98);
            var USDSalaryInLeva = (NikiSalaryInUSD * currencyRateUSA) + yourSalary;
            var totalSum = (decimal)pricePersonal + USDSalaryInLeva;

            var leftMoney = Math.Abs(budget - totalSum);
            Console.WriteLine(totalSum <= budget ? $"The amount is: {totalSum:f2} lv.\nYES \\ Left: {leftMoney:f2} lv."
                : $"The amount is: {totalSum:f2} lv.\nNO \\ Need more: {leftMoney:f2} lv.");
        }
    }
}
