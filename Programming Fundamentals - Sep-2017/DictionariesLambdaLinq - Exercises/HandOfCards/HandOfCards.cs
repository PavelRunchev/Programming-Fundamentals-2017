using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOfCards
{
    class HandOfCards
    {
        static void Main()
        {
            var dataPLayers = new Dictionary<string, List<int>>();
            var dataCards = new Dictionary<string, int>
            {
                { "2", 2},
                { "3", 3},
                { "4", 4},
                { "5", 5},
                { "6", 6},
                { "7", 7},
                { "8", 8},
                { "9", 9},
                { "10", 10},
                { "J", 11},
                { "Q", 12},
                { "K", 13},
                { "A", 14},
            };
            var dataTypes = new Dictionary<string, int>
            {
                { "S", 4 },
                { "H", 3 },
                { "D", 2 },
                { "C", 1 }
            };

            string input = Console.ReadLine();
            while(input != "JOKER")
            {
                string[] tokens = input.Split(new string[] { ": ", ", " }, 
                    StringSplitOptions.RemoveEmptyEntries);
                string player = tokens[0];
                string[] cards = tokens.Skip(1).ToArray();
                if (!dataPLayers.ContainsKey(player))
                {
                    dataPLayers.Add(player, new List<int>());
                }
                for (int i = 0; i < cards.Length; i++)
                {
                    string power = cards[i].Substring(0, cards[i].Length - 1);
                    string type = cards[i].Substring(cards[i].Length - 1);                 
                    dataPLayers[player].Add(dataCards[power] * dataTypes[type]);                                    
                }
                
                input = Console.ReadLine();
            }

            foreach (var player in dataPLayers)
            {
                var playerCards = player.Value.Distinct().ToList();
                Console.WriteLine($"{player.Key}: {playerCards.Sum()}");
            }
        }
    }
}
