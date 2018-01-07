using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataRainAir = new Dictionary<string, List<int>>();
            string inputRainAir;
            while ((inputRainAir = Console.ReadLine()) != "I believe I can fly!")
            {

                string[] tokens;
                string customerName;
                int separator = inputRainAir.IndexOf(" = ");
                if(separator != -1)
                {
                    tokens = inputRainAir
                        .Split(new string[] { " = " },
                        StringSplitOptions.RemoveEmptyEntries);
                    customerName = tokens[0];
                    string customer2Name = tokens[1];
                    if (dataRainAir.ContainsKey(customer2Name))
                    {
                        if (!dataRainAir.ContainsKey(customerName))
                        {
                            dataRainAir.Add(customerName, new List<int>());
                        }
                        dataRainAir[customerName] = dataRainAir[customer2Name];
                    }
                }
                else
                {
                    tokens = inputRainAir.Split();
                    customerName = tokens[0];
                    List<int> customerFlight = tokens.Skip(1).Select(int.Parse).OrderBy(f => f).ToList();
                    if (!dataRainAir.ContainsKey(customerName))
                    {
                        dataRainAir.Add(customerName, new List<int>());
                        dataRainAir[customerName] = customerFlight;
                    }
                    else
                    {
                        List<int> addCustomer = customerFlight.Concat(dataRainAir[customerName]).OrderBy(f => f).ToList();
                        dataRainAir[customerName] = addCustomer;
                    }              
                }
            }

            var orderedCustomersByCount = dataRainAir
                .OrderByDescending(c => c.Value.Count())
                .ThenBy(name => name.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var customer in orderedCustomersByCount)
            {
                string name = customer.Key;
                List<int> flights = customer.Value;
                Console.WriteLine($"#{name} ::: {string.Join(", ", flights)}");
            }
        }
    }
}
