using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class DragonArmy
    {
        static void Main()
        {
		var dataDragons = new Dictionary<string, Dictionary<string, List<int>>>();
            var countOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfDragons; i++)
            {
                string[] inputDragon = Console.ReadLine().Split();
                string type = inputDragon[0];
                string name = inputDragon[1];
                int damage = inputDragon[2] != "null" ? int.Parse(inputDragon[2]) : 45;
                int health = inputDragon[3] != "null" ? int.Parse(inputDragon[3]) : 250;
                int armor = inputDragon[4] != "null" ? int.Parse(inputDragon[4]) : 10;
                if (!dataDragons.ContainsKey(type))
                {
                    dataDragons.Add(type, new Dictionary<string, List<int>>());
                }
                if (!dataDragons[type].ContainsKey(name))
                {
                    dataDragons[type].Add(name, new List<int>() { 0, 0, 0 });
                }
                dataDragons[type][name][0] = damage;
                dataDragons[type][name][1] = health;
                dataDragons[type][name][2] = armor;
            }

            foreach (var type in dataDragons)
            {
                string typeDragon = type.Key;
                double averageDamage = type.Value.Average(d => d.Value[0]);
                double averageHealth = type.Value.Average(d => d.Value[1]);
                double averageArmor = type.Value.Average(d => d.Value[2]);
                Console.WriteLine($"{typeDragon}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (var dragon in type.Value.OrderBy(d => d.Key))
                {
                    string name = dragon.Key;
                    int damage = dragon.Value[0];
                    int health = dragon.Value[1];
                    int armor = dragon.Value[2];
                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }	
        }    
    }
}
