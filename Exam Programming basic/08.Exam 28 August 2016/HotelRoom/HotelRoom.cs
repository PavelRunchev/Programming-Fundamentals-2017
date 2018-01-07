using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            var month = Console.ReadLine();
            var numberSleeps = int.Parse(Console.ReadLine());

            var discountApartment = 0.0;
            var discountStudio = 0.0;
            switch(month)
            {
                case "May":
                case "October":
                    if (numberSleeps > 7 && numberSleeps <= 14)
                    {
                        discountApartment = 65 * numberSleeps;
                        discountStudio = 50 * 0.95 * numberSleeps;
                    }
                    else if(numberSleeps > 14)
                    {                   
                        discountApartment = 65 * 0.90 * numberSleeps;
                        discountStudio = 50 * 0.70 * numberSleeps;
                    }
                    else
                    {               
                        discountApartment = 65 * numberSleeps;
                        discountStudio = 50 * numberSleeps;
                    }
                        break;
                case "June":
                case "September":
                    if(numberSleeps > 14)
                    {              
                        discountApartment = 68.70 * 0.90 * numberSleeps;
                        discountStudio = 75.20 * 0.80 * numberSleeps;
                    }
                    else
                    {                     
                        discountApartment = 68.70 * numberSleeps;
                        discountStudio = 75.20 * numberSleeps;
                    }
                    break;
                case "July":
                case "August":
                    if(numberSleeps > 14)
                    {
                        discountApartment = 77 * 0.90 * numberSleeps;
                        discountStudio = 76 * numberSleeps;
                    }                      
                    else
                    {                  
                        discountApartment = 77 * numberSleeps;
                        discountStudio = 76 * numberSleeps;
                    }
                        break;
            }
            Console.WriteLine($"Apartment: {discountApartment:f2} lv.\nStudio: {discountStudio:f2} lv.");
        }
    }
}
