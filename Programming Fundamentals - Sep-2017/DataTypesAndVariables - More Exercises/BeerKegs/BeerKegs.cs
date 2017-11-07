using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    class BeerKegs
    {
        static void Main()
        {
            int numberOfLine = int.Parse(Console.ReadLine());
            double biggestVolumeKeg = 0;
            string biggestKeg = string.Empty;
            for (int i = 0; i < numberOfLine; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if(volume > biggestVolumeKeg)
                {
                    biggestVolumeKeg = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
