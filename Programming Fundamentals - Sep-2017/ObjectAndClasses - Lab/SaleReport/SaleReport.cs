using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleReport
{
    class Sale
    {
        public string Town { get; set; }   
        public decimal TotalSum { get; set; }

        public Sale(string town, string product, decimal price, double quantity)
        {
            this.Town = town;       
            this.TotalSum += price * (decimal)quantity;
        }
    }

    class SaleReport
    {
        static void Main()
        {
            List<Sale> townsList = new List<Sale>();
            int numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] input = Console.ReadLine().Split();
                string town = input[0];
                string product = input[1];
                decimal price = decimal.Parse(input[2]);
                double quantity = double.Parse(input[3]);
                
                var data = townsList.FirstOrDefault(t => t.Town == town);
                if (data == null)
                {
                    Sale towns = new Sale(town, product, price, quantity);
                    townsList.Add(towns);
                }
                else
                {
                    var datali = data.Town == town;
                    int index = townsList.IndexOf(townsList.Find(t => t.Town == town));
                    if(datali == true)
                    {
                        townsList[index].TotalSum += price * (decimal)quantity;
                    }          
                }          
            }

            var orderedTowns = townsList.OrderBy(t => t.Town).ToList();

            foreach (var city in orderedTowns)
            {
                Console.WriteLine($"{city.Town} -> {city.TotalSum:f2}");
            }           
        }
    }
}
