using System;
using System.Collections.Generic;

namespace VaporStore
{
    class VaporStore
    {
        static void Main()
        {
            var dataGames = new Dictionary<string, decimal>();
            dataGames["OutFall 4"] = 39.99m;
            dataGames["CS: OG"] = 15.99m;
            dataGames["Zplinter Zell"] = 19.99m;
            dataGames["Honored 2"] = 59.99m;
            dataGames["RoverWatch"] = 29.99m;
            dataGames["RoverWatch Origins Edition"] = 39.99m;

            var money = decimal.Parse(Console.ReadLine());
            var spent = 0m;
            var remainingMoney = 0m;
            var currentBalance = money;
            string inputBuyGame = Console.ReadLine();
            while(inputBuyGame != "Game Time")
            {
                if(dataGames.ContainsKey(inputBuyGame))
                {
                    decimal priceOfGame = dataGames[inputBuyGame];
                    if (priceOfGame > currentBalance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= dataGames[inputBuyGame];
                        spent += dataGames[inputBuyGame];
                        Console.WriteLine($"Bought {inputBuyGame}");
                    }                
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                
                inputBuyGame = Console.ReadLine();
            }

            if (currentBalance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                remainingMoney = money - spent;
                Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${remainingMoney:f2}");
            }
        }
    }
}
