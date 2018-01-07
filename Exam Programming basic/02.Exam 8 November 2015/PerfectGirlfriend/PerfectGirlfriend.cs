using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectGirlfriend
{
    class PerfectGirlfriend
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var counterGirls = 0;
            while (input != "Enough dates!")
            {
                
                string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                int daysNumber = 0;
                int sumForGsm = 0;

                string[] data = input.Split('\\');
                string days = data[0];
                long gsm = Convert.ToInt64(data[1]);
                string bra = data[2];
                string name = data[3];
                //weekNumbers
                for (int i = 0; i < week.Length; i++)
                {
                    if (days == week[i])
                        daysNumber = i + 1;
                }
                // gsmNumbers
                while (gsm > 0)
                {
                    long digit = gsm % 10;
                    sumForGsm += (int)digit;
                    gsm /= 10;
                }
                // BraNumbers
                int length = bra.Length - 1;
                int braNumber = int.Parse(bra.Substring(0, length));         
                int braLetter = (char)bra[bra.Length - 1];              
                // NameNumbers
                int firstLetter = (char)name[0];
                int lengthName = name.Length;

                var result = daysNumber + sumForGsm + (braNumber * braLetter) - (firstLetter * lengthName);
                if (result >= 6000)
                {
                    counterGirls++;
                    Console.WriteLine($"{name} is perfect for you.");
                }
                else
                {
                    Console.WriteLine($"Keep searching, {name} is not for you.");
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine(counterGirls);
        }
    }
}
