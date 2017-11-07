using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class BikeRace
    {
        static void Main()
        {
            var numberJuniors = int.Parse(Console.ReadLine());
            var numberSeniors = int.Parse(Console.ReadLine());
            var typeRoute = Console.ReadLine();
            var feeJuniors = 0.0;
            var feeSeniors = 0.0;
            var group = numberJuniors + numberSeniors;
            switch(typeRoute)
            {
                case "trail": feeJuniors = 5.50; feeSeniors = 7; break;
                case "cross-country": feeJuniors = 8; feeSeniors = 9.50;
                    if(group >= 50)
                    {
                        feeJuniors = 8 * 0.75;
                        feeSeniors = 9.50 * 0.75;
                    }
                    break;
                case "downhill": feeJuniors = 12.25; feeSeniors = 13.75; break;
                case "road": feeJuniors = 20; feeSeniors = 21.50; break;
            }
            var sum = (numberJuniors * feeJuniors) + (numberSeniors * feeSeniors);       
            var totalSum = sum * 0.95;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
