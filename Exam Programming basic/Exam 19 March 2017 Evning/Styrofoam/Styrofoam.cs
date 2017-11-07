using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Styrofoam
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var numberWindows = int.Parse(Console.ReadLine());
            var numberStyrofoam = double.Parse(Console.ReadLine());
            var priceForPacketStyrofoam = double.Parse(Console.ReadLine());

            var windowsArea = numberWindows * 2.4;
            var cleanArea = houseArea - windowsArea;
            var totalArea = cleanArea + (cleanArea * 0.10);

            var needPacketStyrofoam = Math.Ceiling(totalArea / numberStyrofoam);
            var priceAllStyrofoam = needPacketStyrofoam * priceForPacketStyrofoam;
            var left = Math.Abs(priceAllStyrofoam - budget);
            Console.WriteLine(priceAllStyrofoam <= budget ? 
                $"Spent: {priceAllStyrofoam:f2}\nLeft: {left:f2}" 
                : $"Need more: {left:f2}");
        }
    }
}
