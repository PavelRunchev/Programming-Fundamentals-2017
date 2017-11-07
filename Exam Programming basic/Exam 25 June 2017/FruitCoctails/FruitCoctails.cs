using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCoctails
{
    class FruitCoctails
    {
        static void Main()
        {
            var fruit = Console.ReadLine();
            var sizeOfCoctail = Console.ReadLine();
            var numberOfCoctails = int.Parse(Console.ReadLine());
            var price = 0.0;
            switch(fruit)
            {
                case "Watermelon":
                    {
                        switch(sizeOfCoctail)
                        {
                            case "small": price = 56 * 2; break;
                            case "big": price = 28.70 * 5; break;
                        }
                    }
                    break;
                case "Mango":
                    {
                        switch (sizeOfCoctail)
                        {
                            case "small": price = 36.66 * 2; break;
                            case "big": price = 19.60 * 5; break;
                        }
                    }
                    break;
                case "Pineapple":
                    {
                        switch (sizeOfCoctail)
                        {
                            case "small": price = 42.10 * 2; break;
                            case "big": price = 24.80 * 5; break;
                        }
                    }
                    break;
                case "Raspberry":
                    {
                        switch (sizeOfCoctail)
                        {
                            case "small": price = 20 * 2; break;
                            case "big": price = 15.20 * 5; break;
                        }
                    }
                    break;
            }
            var priceOfCoctails = price * numberOfCoctails;
            if(priceOfCoctails >= 400 && priceOfCoctails <= 1000)
            {
                priceOfCoctails = priceOfCoctails * 0.85;
            }
            if(priceOfCoctails > 1000)
            {
                priceOfCoctails = priceOfCoctails * 0.50;
            }
            Console.WriteLine($"{priceOfCoctails:f2} lv.");
        }
    }
}
