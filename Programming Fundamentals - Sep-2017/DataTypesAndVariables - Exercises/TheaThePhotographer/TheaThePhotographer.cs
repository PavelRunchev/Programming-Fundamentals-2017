using System;

namespace TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main()
        {
            var numberOfPictures = long.Parse(Console.ReadLine());
            var filterTimeInSeconds = int.Parse(Console.ReadLine());
            var filterPercentage = int.Parse(Console.ReadLine());
            var amountFiltredPicture = int.Parse(Console.ReadLine());

            long filteredPictures =  (long)Math.Ceiling(numberOfPictures * (filterPercentage / 100.0));
            long totalTimePerSeconds = (long)(numberOfPictures * filterTimeInSeconds) + (long)(filteredPictures * amountFiltredPicture);
            
            TimeSpan times = TimeSpan.FromSeconds(totalTimePerSeconds);
            Console.WriteLine($"{times.ToString(@"d\:hh\:mm\:ss")}");
        }
    }
}
