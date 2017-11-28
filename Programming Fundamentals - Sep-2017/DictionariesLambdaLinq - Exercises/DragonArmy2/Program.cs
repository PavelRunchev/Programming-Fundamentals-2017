using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Dragon(string name, int damage, int health, int armor)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
    }

    class TypeDragon
    {
        public string Type { get; set; }
        public List<Dragon> Dragons { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var dataDragons = new List<TypeDragon>();
            int numberOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] inputDragon = Console.ReadLine().Split(' ');
                string type = inputDragon[0];
                string name = inputDragon[1];
                int damage = inputDragon[2] == "null" ? 45 : int.Parse(inputDragon[2]);
                int health = inputDragon[3] == "null" ? 250 : int.Parse(inputDragon[3]);
                int armor = inputDragon[4] == "null" ? 10 : int.Parse(inputDragon[4]);

                if ((!dataDragons.Any(a => a.Type == type)))
                {
                    Dragon dragon = new Dragon(name, damage, health, armor);
                    TypeDragon typeDragon = new TypeDragon();
                    typeDragon.Type = type;
                    typeDragon.Dragons = new List<Dragon>();
                    typeDragon.Dragons.Add(dragon);
                    dataDragons.Add(typeDragon);
                }
                else if (dataDragons.Any(t => t.Type == type))
                {
                    var curentType = dataDragons.FirstOrDefault(t => t.Type == type);
                    if (!curentType.Dragons.Any(n => n.Name == name))
                    {
                        Dragon dragon = new Dragon(name, damage, health, armor);
                        curentType.Dragons.Add(dragon);
                    }
                    else
                    {
                        var curentDragon = curentType.Dragons.FirstOrDefault(n => n.Name == name);
                        curentDragon.Damage = damage;
                        curentDragon.Health = health;
                        curentDragon.Armor = armor;
                    }
                }
            }

            PrintDragons(dataDragons);
        }

        private static void PrintDragons(List<TypeDragon> dataDragons)
        {
            foreach (var types in dataDragons)
            {
                string typeDragon = types.Type;
                var listDragons = types.Dragons.OrderBy(n => n.Name).ToList();
                double averageDamage = listDragons.Average(a => a.Damage);
                double averageHealth = listDragons.Average(a => a.Health);
                double averageArmor = listDragons.Average(a => a.Armor);
                Console.WriteLine($"{typeDragon}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (var dragon in listDragons)
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}
