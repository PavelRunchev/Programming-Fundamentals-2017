using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HornetAssault
{
    class HornetAssault
    {
        static void Main()
        {
            List<long> beehives = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            List<long> hornets = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            List<long> aliveBees = new List<long>();
            for (int i = 0; i < beehives.Count; i++)
            {
                long hornetPower = hornets.Sum();
                long beehive = beehives[i];
                if(beehive >= hornetPower)
                {
                    if(beehive - hornetPower > 0)
                    {
                        aliveBees.Add(beehive - hornetPower);
                    }
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }                
                }
            }

            Console.WriteLine(aliveBees.Count > 0 ? $"{string.Join(" ",aliveBees)}" : $"{string.Join(" ", hornets)}");
        }
    }
}
