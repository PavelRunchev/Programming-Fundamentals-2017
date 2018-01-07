using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main()
        {
            var numberOfLine = int.Parse(Console.ReadLine());
            var capacityOfTank = 255;
            var flowQuantities = 0;
            for (int i = 0; i < numberOfLine; i++)
            {
                int quantityOfWater = int.Parse(Console.ReadLine());
                if (flowQuantities + quantityOfWater > capacityOfTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                if(flowQuantities + quantityOfWater <= capacityOfTank)
                {
                    flowQuantities += quantityOfWater;
                }             
            }
            Console.WriteLine(flowQuantities);
        }
    }
}
