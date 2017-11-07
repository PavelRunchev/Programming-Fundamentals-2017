using System;

namespace ResaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main()
        {
            var group = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            string hall = string.Empty;
            decimal priceHall = 0;
            decimal price = 0;
            decimal discount = 0;
            if(group <= 50)
            {
                hall = "Small Hall";
                priceHall = 2500;
            }
            else if (group > 50 && group <= 100)
            {
                hall = "Terrace";
                priceHall = 5000;
            }
            else if(group > 100 && group <= 120)
            {
                hall = "Great Hall";
                priceHall = 7500;
            }
            else if(group > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch(package)
            {
                case "Normal": price = 500; discount = 0.95m; break;
                case "Gold": price = 750; discount = 0.90m; break;
                case "Platinum": price = 1000; discount = 0.85m; break;                
            }
            decimal totalPrice = (priceHall + price) * discount;
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {totalPrice / group:f2}$");
        }
    }
}
