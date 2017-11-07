using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolCamp
{
    class ScoolCamp
    {
        static void Main()
        {
            var season = Console.ReadLine();
            var typeGroup = Console.ReadLine();
            var numberOfStudents = int.Parse(Console.ReadLine());
            var numberOfNights = int.Parse(Console.ReadLine());

            var price = 0.0;
            var typeSport = string.Empty;
            switch(season)
            {
                case "Winter":
                    switch(typeGroup)
                    {
                        case "boys": price = 9.60; typeSport = "Judo"; break;
                        case "girls": price = 9.60; typeSport = "Gymnastics"; break;
                        case "mixed": price = 10.00; typeSport = "Ski"; break;
                    }
                    break;
                case "Spring":
                    switch (typeGroup)
                    {
                        case "boys": price = 7.20; typeSport = "Tennis"; break;
                        case "girls": price = 7.20; typeSport = "Athletics"; break;
                        case "mixed": price = 9.50; typeSport = "Cycling"; break;
                    }
                    break;
                case "Summer":
                    switch (typeGroup)
                    {
                        case "boys": price = 15.00; typeSport = "Football"; break;
                        case "girls": price = 15.00; typeSport = "Volleyball";  break;
                        case "mixed": price = 20.00; typeSport = "Swimming"; break;
                    }
                    break;
            }
            var priceForNights = numberOfStudents * price * numberOfNights;
            if(numberOfStudents >= 10 && numberOfStudents < 20)
            {
                priceForNights = priceForNights * 0.95;
            }
            else if(numberOfStudents >= 20 && numberOfStudents < 50)
            {
                priceForNights = priceForNights * 0.85;
            }
            else if(numberOfStudents >= 50)
            {
                priceForNights = priceForNights * 0.50;
            }
            Console.WriteLine($"{typeSport} {priceForNights:f2} lv.");
        }
    }
}
