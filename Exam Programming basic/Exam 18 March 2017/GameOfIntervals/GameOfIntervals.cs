using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main()
        {
            var stepOfGame = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var space1 = 0;
            var space2 = 0;
            var space3 = 0;
            var space4 = 0;
            var space5 = 0;
            var invalid = 0;
            for (int i = 0; i < stepOfGame; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if(number >= 0 && number <= 9)
                {
                    space1++;
                    sum += number * 0.20;
                }
                else if(number >= 10 && number <= 19)
                {
                    space2++;
                    sum += number * 0.30;
                }
                else if(number >= 20 && number <= 29)
                {
                    space3++;
                    sum += number * 0.40;
                }
                else if(number >= 30 && number <= 39)
                {
                    space4++;
                    sum += 50;
                }
                else if(number >= 40 && number <= 50)
                {
                    space5++;
                    sum += 100;
                }
                else
                {
                    invalid++;
                    sum /= 2;
                }
            }
            Console.WriteLine($"{sum:f2}");
            Console.WriteLine($"From 0 to 9: {(double)space1 / stepOfGame * 100.0:f2}%");
            Console.WriteLine($"From 10 to 19: {(double)space2 / stepOfGame * 100.0:f2}%");
            Console.WriteLine($"From 20 to 29: {(double)space3 / stepOfGame * 100.0:f2}%");
            Console.WriteLine($"From 30 to 39: {(double)space4 / stepOfGame * 100.0:f2}%");
            Console.WriteLine($"From 40 to 50: {(double)space5 / stepOfGame * 100.0:f2}%");
            Console.WriteLine($"Invalid numbers: {(double)invalid / stepOfGame * 100.0:f2}%");
        }
    }
}
