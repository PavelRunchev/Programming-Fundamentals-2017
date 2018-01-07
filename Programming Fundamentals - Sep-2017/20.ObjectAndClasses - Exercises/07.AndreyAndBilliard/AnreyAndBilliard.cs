using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> BoughtProduct { get; set; }
        public decimal Bill { get; set; }
    }
    class AnreyAndBilliard
    {
        static void Main()
        {
            var dataCustomers = new List<Customer>();
            var dataShop = new Dictionary<string, decimal>();
            var numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] inputProduct = Console.ReadLine().Split('-');
                string product = inputProduct[0];
                decimal price = decimal.Parse(inputProduct[1]);
                if (!dataShop.ContainsKey(product))
                {
                    dataShop.Add(product, 0);
                }
                dataShop[product] = price;
            }

            string[] customers = Console.ReadLine().Split('-', ',');
            while(customers[0] != "end of clients")
            {
                string nameCustomer = customers[0];
                string boughtProduct = customers[1];

                int quantity = int.Parse(customers[2]);
                if (dataShop.ContainsKey(boughtProduct))
                {
                    if (!dataCustomers.Any(n => n.Name == nameCustomer))
                    {
                        Customer customer = new Customer();
                        customer.Name = nameCustomer;
                        customer.Bill += (decimal)quantity * dataShop[boughtProduct];
                        if (customer.BoughtProduct == null)
                        {
                            customer.BoughtProduct = new Dictionary<string, int>();
                        }
                        if (!customer.BoughtProduct.ContainsKey(boughtProduct))
                        {
                            customer.BoughtProduct.Add(boughtProduct, 0);
                        }
                        customer.BoughtProduct[boughtProduct] += quantity;

                        dataCustomers.Add(customer);
                    }
                    else
                    {
                        var currentCustomer = dataCustomers.FirstOrDefault(c => c.Name == nameCustomer);
                        if (!currentCustomer.BoughtProduct.ContainsKey(boughtProduct))
                        {
                            currentCustomer.BoughtProduct.Add(boughtProduct, 0);
                        }
                        currentCustomer.BoughtProduct[boughtProduct] += quantity;
                        currentCustomer.Bill += (decimal)quantity * dataShop[boughtProduct];
                    }                  
                }
                customers = Console.ReadLine().Split('-', ',');
            }

            var orderedCustomer = dataCustomers.OrderBy(c => c.Name).ToList();

            decimal totalBill = 0;
            foreach (var customer in orderedCustomer)
            {
                Console.WriteLine(customer.Name);
                var boughtProducts = customer.BoughtProduct
                    .ToDictionary(k => k.Key, v => v.Value);
                foreach (var item in boughtProducts)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
                totalBill += customer.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
