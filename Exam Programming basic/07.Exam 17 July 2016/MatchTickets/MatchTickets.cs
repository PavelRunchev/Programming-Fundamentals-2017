using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var numberPeoples = int.Parse(Console.ReadLine());
            var budgetAfterTransport = 0.0;
            var numberTickets = 0d;
            var typeCategory = string.Empty;
            switch(category)
            {
                case "VIP": numberTickets = 499.99 * numberPeoples; break;
                case "Normal": numberTickets = 249.99 * numberPeoples;break; 
            }
            if(numberPeoples <= 4)
            {
                budgetAfterTransport = budget * 0.25;
            }
            else if(numberPeoples <= 9)
            {
                budgetAfterTransport = budget * 0.40;
            }
            else if(numberPeoples <= 24)
            {
                budgetAfterTransport = budget * 0.50;
            }
            else if(numberPeoples <= 49)
            {
                budgetAfterTransport = budget * 0.60;
            }
            else if(numberPeoples >= 50)
            {
                budgetAfterTransport = budget * 0.75;
            }

            if(numberTickets <= budgetAfterTransport)
            {
                Console.WriteLine($"Yes! You have {budgetAfterTransport - numberTickets:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {numberTickets - budgetAfterTransport:f2} leva.");
            }
        }
    }
}
