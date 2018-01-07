using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuResults
{
    class SudokuResults
    {
        static void Main()
        {      
            var totalSeconds = 0;
            var star = string.Empty;
            var counter = 0;
            string gameTime = Console.ReadLine();
            while (gameTime != "Quit")
            {
                int minute = int.Parse(gameTime.Substring(0, 2));
                int seconds = int.Parse(gameTime.Substring(3, 2));
                counter++;
                totalSeconds += (minute * 60) + seconds;
                gameTime = Console.ReadLine();
            }
            var average = Math.Ceiling(totalSeconds / (double)counter);

            if (average < 720)
            {
                star = "Gold";
            }
            else if (average > 720 && average < 1440)
            {
                star = "Silver";
            }
            else if (average > 1440)
            {
                star = "Bronze";
            }

            Console.WriteLine($"{star} Star");
            Console.WriteLine($"Games - {counter} \\ Average seconds - {average}");
        }
    }
}
