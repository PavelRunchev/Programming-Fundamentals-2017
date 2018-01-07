using System;

namespace TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main()
        {
            var budjet = double.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());

            double subtotal = 0;
            for (int i = 0; i < numberOfItems; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                subtotal += price * count;
                if(count == 1)
                {
                    Console.WriteLine($"Adding {count} {name} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {count} {name}s to cart.");
                }
                
            }
            Console.WriteLine($"Subtotal: ${subtotal:f2}");
            double left = Math.Abs(budjet - subtotal);
            Console.WriteLine(budjet >= subtotal ? $"Money left: ${left:f2}" : $"Not enough. We need ${left:f2} more.");
        }
    }
}
