using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertrain
{
    class Entertrain
    {
        static void Main()
        {
            List<int> trains = new List<int>();
            int locoPower = int.Parse(Console.ReadLine());
            int wagonWeight = 0;
            string inputWagons;
            while ((inputWagons = Console.ReadLine()) != "All ofboard!")
            {
                int wagon;
                if (int.TryParse(inputWagons, out wagon))
                {
                    wagonWeight += wagon;
                    trains.Add(wagon);
                    if(wagonWeight > locoPower)
                    {
                        int average = (int)trains.Average();
                        int position = 0;
                        int closestValue = int.MaxValue;
                        for (int i = 0; i < trains.Count; i++)
                        {
                            int currentWagon = trains[i];
                            int closestWagon = Math.Abs(currentWagon - average);
                            if(closestWagon < closestValue)
                            {
                                closestValue = closestWagon;
                                position = i;
                            }
                        }
                        trains.RemoveAt(position);
                    }
                }
            }

            trains.Reverse();
            trains.Add(locoPower);
            Console.WriteLine(string.Join(" ", trains));
        }
    }
}
