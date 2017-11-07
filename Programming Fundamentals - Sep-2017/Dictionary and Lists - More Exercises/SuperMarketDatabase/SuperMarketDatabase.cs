using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDatabase
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalSum { get; set; }
    }
    class SuperMarketDatabase
    {
        static void Main()
        {
            var database = new List<Product>();
            string[] input = Console.ReadLine().Split();
            while(input[0] != "stocked")
            {
                string name = input[0];
                decimal price = decimal.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if(!database.Any(a => a.Name == name))
                {
                    Product product = new Product();
                    product.Name = name;
                    product.Price = price;
                    product.Quantity = quantity;
                    product.TotalSum = price * quantity;
                    database.Add(product);
                }
                else
                {
                    int index = database.IndexOf(database.Find(n => n.Name == name));
                    database[index].Price = price;
                    database[index].Quantity += quantity;
                    database[index].TotalSum = database[index].Price * database[index].Quantity;
                }

                input = Console.ReadLine().Split();
            }

            decimal grandTotal = 0;
            foreach (var product in database)
            {
                Console.WriteLine($"{product.Name}: ${product.Price:f2} * {product.Quantity} = ${product.TotalSum:f2}");
                grandTotal += product.TotalSum;
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
