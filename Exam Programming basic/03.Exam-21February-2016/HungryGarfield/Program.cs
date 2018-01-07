using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class Program
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal dollarRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            uint pizza = uint.Parse(Console.ReadLine());
            uint lazagna = uint.Parse(Console.ReadLine());
            uint sandwich = uint.Parse(Console.ReadLine());

            decimal price = (((pizzaPrice / dollarRate) * pizza) + ((lasagnaPrice / dollarRate) * lazagna) + ((sandwichPrice / dollarRate) * sandwich));
            if(price <= money)
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${money - price:f2}.");
            }
            else
            {
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${price - money:f2}.");
            }
        }
    }
}
