using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main()
        {
            var lengthInMeter = double.Parse(Console.ReadLine());
            var widthInMeter = double.Parse(Console.ReadLine());

            var widthInSantimeter = (widthInMeter * 100) - 100;
            var desk = Math.Floor(widthInSantimeter / 70.0);

            var lengthInSantimeter = lengthInMeter * 100;
            var row = Math.Floor(lengthInSantimeter / 120.0);

            var numberDesk = desk * row - 3;
            Console.WriteLine(numberDesk);

        }
    }
}
