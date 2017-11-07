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
            string[] participants = Console.ReadLine().Split(' ');
            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < participants.Length; i++)
            {
                string driver = participants[i];
                double fuel = (int)driver[0];
                bool isFinish = true;
                for (int c = 0; c < zones.Length; c++)
                {
                    if(checkpoints.Contains(c))
                    {
                        fuel += zones[c]; 
                    }
                    else
                    {
                        fuel -= zones[c];
                    }
                    if(fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {c}");
                        isFinish = false;
                        break;
                    }
                }
                if (isFinish)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }            
        }
    }
}
