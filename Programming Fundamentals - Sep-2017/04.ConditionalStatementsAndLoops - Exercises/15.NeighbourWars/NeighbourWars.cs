using System;

namespace NeighbourWars
{
    class NeighbourWars
    {
        static void Main()
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;
            int count = 1;
            while (true)
            {
                if(count % 2 != 0)
                {
                    goshoHealth -= peshoDamage;          
                }
                if(count % 2 == 0)
                {
                    peshoHealth -= goshoDamage;              
                }
                
                if(peshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {count}th round.");
                    break;
                }
                if(goshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {count}th round.");
                    break;
                }
                if(count % 2 != 0)
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                if(count % 2 == 0)
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                if(count % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                count++;
            }
        }
    }
}
