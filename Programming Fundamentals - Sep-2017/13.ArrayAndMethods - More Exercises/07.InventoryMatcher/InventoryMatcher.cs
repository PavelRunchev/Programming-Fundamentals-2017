using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main()
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantityProducts = Console.ReadLine()
                .Split(' ').Select(long.Parse)
                .ToArray();
            decimal[] priceProducts = Console.ReadLine()
                .Split(' ').Select(decimal.Parse)
                .ToArray();

            string input = Console.ReadLine();
            while(input != "done")
            {
                int index = Array.IndexOf(products, input);
                Console.WriteLine($"{input} costs: {priceProducts[index]}; Available quantity: {quantityProducts[index]}");
                input = Console.ReadLine();
            }
        }
    }
}
