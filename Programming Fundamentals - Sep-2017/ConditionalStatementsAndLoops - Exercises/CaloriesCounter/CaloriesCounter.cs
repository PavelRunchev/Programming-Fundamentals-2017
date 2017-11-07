using System;

namespace CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main()
        {
            var dataIngedients = new Dictionary<string, int>();
            dataIngedients["cheese"] = 500;
            dataIngedients["tomato sauce"] = 150;
            dataIngedients["salami"] = 600;
            dataIngedients["pepper"] = 50;

            int numberOfIngredient = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numberOfIngredient; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if(dataIngedients.ContainsKey(ingredient))
                {
                    count += dataIngedients[ingredient];
                }
            }
            Console.WriteLine($"Total calories: {count}");
        }
    }
}
