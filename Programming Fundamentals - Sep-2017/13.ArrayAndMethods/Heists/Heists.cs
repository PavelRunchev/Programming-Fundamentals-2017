using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heists
{
    class Heists
    {
        static void Main()
        {
            var inputPrice = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            int priceJewels = inputPrice[0];
            int priceGold = inputPrice[1];

            long earningJewels = 0;
            long earningGold = 0;
            long totalExpense = 0;
            string inputLoots = Console.ReadLine();
            while (inputLoots != "Jail Time")
            {
                string[] tokensLoots = inputLoots.Split(' ');
                string loot = tokensLoots[0];
                int expense = int.Parse(tokensLoots[1]);
                for (int i = 0; i < loot.Length; i++)
                {
                    string searchElement = loot[i].ToString();
                    if(searchElement == "%")
                    {
                        earningJewels += priceJewels;
                    }
                    else if(searchElement == "$")
                    {
                        earningGold += priceGold;
                    }
                }
                totalExpense += expense;

                inputLoots = Console.ReadLine();
            }

            long totalEarning = (earningGold + earningJewels) - totalExpense;
            if(totalEarning >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarning}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalEarning)}.");
            }
        }
    }
}
