using System;

namespace TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main()
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            var price = 0;

            if(day == "weekday")
            {
                if((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 12;
                }
                else if(age > 18 && age <= 64)
                {
                    price = 18;
                }
            }
            else if (day == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 15;
                }
                else if(age > 18 && age <= 64)
                {
                    price = 20;
                }
            }
            if (day == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if(age > 64 && age <= 122)
                {
                    price = 10;
                }
                else if(age > 18 && age <= 64)
                {
                    price = 12;
                }
            }
            Console.WriteLine(price > 0 && price < 122 ? $"{price}$" : "Error!");
        }
    }
}
