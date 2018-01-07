using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmuneSystem
{
    class ImmuneSystem
    {
        static void Main()
        {
            var dataVirus = new List<string>();
            int initialHealth = int.Parse(Console.ReadLine());

            int health = initialHealth;
            string virus = Console.ReadLine();
            while (virus != "end")
            {
                int strength = calcVirusStrength(virus);
                int virusStrength = strength / 3;
                int length = virus.Length;
                int defeatTime = virusStrength * length;
                if(dataVirus.Any(v => v == virus))
                {
                    defeatTime = defeatTime / 3;
                }
                int minute = defeatTime / 60;
                int seconds = defeatTime % 60;
                dataVirus.Add(virus);
                Console.WriteLine($"Virus {virus}: {virusStrength} => {defeatTime} seconds");

                health -= defeatTime;
                if(health <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                Console.WriteLine($"{virus} defeated in {minute}m {seconds}s.");
                Console.WriteLine($"Remaining health: {health}");

                int generateHealth = health + (int)(health * 0.20);
                health = Math.Min(initialHealth, generateHealth);
                

                virus = Console.ReadLine();
            }

            Console.WriteLine("Final Health: {0}", health);
        }

        private static int calcVirusStrength(string virus)
        {
            int sumStrengthVirus = 0;
            for (int i = 0; i < virus.Length; i++)
            {
                char letter = virus[i];
                sumStrengthVirus += (int)letter;
            }
            return sumStrengthVirus;
        }
    }
}
