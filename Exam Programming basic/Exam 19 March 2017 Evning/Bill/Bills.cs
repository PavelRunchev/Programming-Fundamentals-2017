using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Bills
    {
        static void Main()
        {
            var months = int.Parse(Console.ReadLine());

            var electrocity = 0.0;
            var water = 0.0;
            var internet = 0.0;
            var other = 0.0;
            for (int i = 0; i < months; i++)
            {
                var elAccount = double.Parse(Console.ReadLine());

                electrocity += elAccount;
                water += 20;
                internet += 15;
                other += (elAccount + 20 + 15) + ((elAccount + 20 + 15) * 0.20);
            }

            var average = (electrocity + water + internet + other) / months;
            Console.WriteLine($"Electricity: {electrocity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
