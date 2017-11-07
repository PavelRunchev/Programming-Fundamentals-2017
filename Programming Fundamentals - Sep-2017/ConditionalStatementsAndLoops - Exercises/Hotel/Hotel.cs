using System;

namespace Hotel
{
    class Hotel
    {
        static void Main()
        {
            var month = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var countStudio = count;
            decimal discountStudio = 1;
            decimal discountDouble = 1;
            decimal discountSuite = 1;
            decimal priceStudio = 0;
            decimal priceDouble = 0;
            decimal priceSuite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    {
                        priceStudio = 50m;
                        priceDouble = 65m;
                        priceSuite = 75m;
                        if(count > 7)
                        {
                            discountStudio = 0.95m;
                        }
                    }
                    break;
                case "June":
                case "September":
                    {
                        priceStudio = 60m;
                        priceDouble = 72m;
                        priceSuite = 82m;
                        if(count > 14)
                        {
                            discountDouble = 0.90m;
                        }
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    {
                        priceStudio = 68m;
                        priceDouble = 77m;
                        priceSuite = 89m;
                        if(count > 14)
                        {
                            discountSuite = 0.85m;
                        }
                    }
                    break;
            }
            if((count > 7 && month == "September") 
                || (count > 7 && month == "October"))
            {
                countStudio--;
            }
            Console.WriteLine($"Studio: {priceStudio * discountStudio * countStudio:f2} lv.");
            Console.WriteLine($"Double: {priceDouble * discountDouble * count:f2} lv.");
            Console.WriteLine($"Suite: {priceSuite * discountSuite * count:f2} lv.");
        }
    }
}
