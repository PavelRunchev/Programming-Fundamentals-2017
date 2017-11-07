using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradedMatcher
{
    class UpgradedMatcher
    {
        static void Main()
        {
            string[] products = Console.ReadLine().Split(' ');
     
            long[] quantityProducts = Console.ReadLine()
                .Split(' ').Select(long.Parse)
                .ToArray();
            quantityProducts = AddQuantityProducts(quantityProducts, products.Length);
            decimal[] priceProducts = Console.ReadLine()
                .Split(' ').Select(decimal.Parse)
                .ToArray();

            string input = Console.ReadLine();
            while (input != "done")
            {
                string[] tokens = input.Split(' ');
                string product = tokens[0];
                long count = long.Parse(tokens[1]);
                int index = Array.IndexOf(products, product);
                if(quantityProducts[index] > 0 && count <= quantityProducts[index])
                {
                    Console.WriteLine($"{product} x {count} costs {priceProducts[index] * (decimal)count:f2}");
                    quantityProducts[index] -= count;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {product}");
                }
               
                input = Console.ReadLine();
            }
        }

        private static long[] AddQuantityProducts(long[] quantityProducts, int length)
        {
            var newArr = new long[length];
            for (int i = 0; i < quantityProducts.Length; i++)
            {
                newArr[i] = quantityProducts[i];
            }
            return newArr;
        }
    }
}
