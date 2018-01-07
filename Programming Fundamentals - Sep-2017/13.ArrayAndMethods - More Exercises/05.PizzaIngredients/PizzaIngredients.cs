using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            var searchedLength = int.Parse(Console.ReadLine());
            string[] ingredients = new string[10];

            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string ingredient = input[i];
                if(ingredient.Length == searchedLength)
                {
                    Console.WriteLine($"Adding {ingredient}.");
                    ingredients[count] = ingredient;
                    count++;
                    if (count >= 10)
                    {
                        break;
                    }
                }              
            }
            ingredients = ingredients.Where(ing => ing != null).ToArray();

            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", ingredients)}.");
        }
    }
}
