using System;
using System.Collections.Generic;

namespace ChooseADrink2._0
{
    class ChooseDrink
    {
        static void Main()
        {
            var dataPerson = new Dictionary<string, string>();
            dataPerson.Add("Athlete", "Water");
            dataPerson.Add("Businessman", "Coffee");
            dataPerson.Add("Businesswoman", "Coffee");
            dataPerson.Add("SoftUni Student", "Beer");
            
            var dataDrink = new Dictionary<string, decimal>();
            dataDrink.Add("Water", 0.70m);
            dataDrink.Add("Coffee", 1.00m);
            dataDrink.Add("Beer", 1.70m);
            dataDrink.Add("Tea", 1.20m);
            

            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            string drink = string.Empty;
            decimal pay = 0;
            if(dataPerson.ContainsKey(profession))
            {
                drink = dataPerson[profession];
            }
            else
            {
                drink = "Tea";
            }
            if(dataDrink.ContainsKey(drink))
            {
                pay = dataDrink[drink] * quantity;
            }
            Console.WriteLine($"The {profession} has to pay {pay:f2}.");
        }
    }
}
