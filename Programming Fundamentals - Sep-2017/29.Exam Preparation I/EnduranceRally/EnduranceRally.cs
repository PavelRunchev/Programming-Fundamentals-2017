using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class EnduranceRally
    {
        static void Main()
        {
            string[] drivers = Console.ReadLine().Split(' ');
            double[] zones = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            int[] checkpoints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                bool isLeftFuel = true;
                string driver = drivers[i];
                double startFuel = (double)(int)driver[0];
         
                for (int c = 0; c < zones.Length; c++)
                {
                    double zone = zones[c];            
                    if (isCheckpoint(c, checkpoints))
                    {
                        startFuel += zones[c];
                    }
                    else
                    {
                        startFuel -= zones[c];
                    }

                    if (startFuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {c}");
                        isLeftFuel = false;
                        break;
                    }
                }
                if (isLeftFuel)
                {
                    Console.WriteLine($"{driver} - fuel left {startFuel:f2}");
                }
            }
        }

        private static bool isCheckpoint(int c, int[] checkpoints)
        {
            bool ischeckpoint = false;
            for (int i = 0; i < checkpoints.Length; i++)
            {
                int index = checkpoints[i];
                if(index == c)
                {
                    ischeckpoint = true;
                    break;
                }
            }
            return ischeckpoint;
        }
    }
}
