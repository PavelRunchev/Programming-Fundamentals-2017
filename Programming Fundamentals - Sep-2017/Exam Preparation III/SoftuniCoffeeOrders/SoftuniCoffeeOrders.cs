using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main()
        {
            var countOfLine = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            for (int i = 0; i < countOfLine; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                int countOfCapsule = int.Parse(Console.ReadLine());

                int numberOfDay = DateTime.DaysInMonth(date.Year, date.Month);
                decimal orderPrice = pricePerCapsule * numberOfDay * countOfCapsule;
                totalPrice += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
