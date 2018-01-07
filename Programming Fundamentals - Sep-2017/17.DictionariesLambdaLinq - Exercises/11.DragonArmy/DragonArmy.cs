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
            var dataDragonsStats = new Dictionary<string, Dictionary<string, List<int>>>();

            int numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] inputDragons = Console.ReadLine().Split(' ');
                string type = inputDragons[0];
                string name = inputDragons[1];
                string damage = inputDragons[2];
                string health = inputDragons[3];
                string armor = inputDragons[4];
                if (!dataDragonsStats.ContainsKey(type))
                {
                    dataDragonsStats.Add(type, new Dictionary<string, List<int>>());
                }
                if (!dataDragonsStats[type].ContainsKey(name))
                {
                    dataDragonsStats[type].Add(name, new List<int>() { 0, 0, 0 });
                }
                if (damage == "null")
                {
                    dataDragonsStats[type][name][0] = 45;
                }
                else
                {
                    dataDragonsStats[type][name][0] = int.Parse(damage);
                }
                if (health == "null")
                {
                    dataDragonsStats[type][name][1] = 250;
                }
                else
                {
                    dataDragonsStats[type][name][1] = int.Parse(health);
                }
                if (armor == "null")
                {
                    dataDragonsStats[type][name][2] = 10;
                }
                else
                {
                    dataDragonsStats[type][name][2] = int.Parse(armor);
                }
            }

            foreach (var typeDragons in dataDragonsStats)
            {
                string type = typeDragons.Key;
                Dictionary<string, List<int>> listDragons = typeDragons.Value
                    .OrderBy(n => n.Key)
                    .ToDictionary(k => k.Key, v => v.Value);
                double damageAverage = listDragons.Average(power => power.Value[0]);
                double healthAverage = listDragons.Average(life => life.Value[1]);
                double armorAverage = listDragons.Average(defence => defence.Value[2]);
                Console.WriteLine($"{type}::({damageAverage:f2}/{healthAverage:f2}/{armorAverage:f2})");
                foreach (var item in listDragons)
                {
                    string nameDragon = item.Key;
                    List<int> statDragon = item.Value;
                    Console.WriteLine($"-{nameDragon} -> damage: {statDragon[0]}, health: {statDragon[1]}, armor: {statDragon[2]}");
                }
            }
        }
    }
}
