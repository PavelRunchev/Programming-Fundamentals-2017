using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main()
        {
            var capacityOfStadium = int.Parse(Console.ReadLine());
            var numberOfFen = int.Parse(Console.ReadLine());
            var countA = 0;
            var countB = 0;
            var countV = 0;
            var countG = 0;
            for (int i = 0; i < numberOfFen; i++)
            {

                var sector = Console.ReadLine();
                if(sector == "A")
                {
                    countA++;
                }
                else if(sector == "B")
                {
                    countB++;
                }
                else if(sector == "V")
                {
                    countV++;
                }
                else if(sector == "G")
                {
                    countG++;
                }
            }
            var precentSectorA = ((double)countA / numberOfFen) * 100.0;
            var precentSectorB = ((double)countB / numberOfFen) * 100.0;
            var precentSectorV = ((double)countV / numberOfFen) * 100.0;
            var precentSectorG = ((double)countG / numberOfFen) * 100.0;
            var precentAllStadium = ((double)numberOfFen / capacityOfStadium) * 100.0;

            Console.WriteLine($"{precentSectorA:f2}%");
            Console.WriteLine($"{precentSectorB:f2}%");
            Console.WriteLine($"{precentSectorV:f2}%");
            Console.WriteLine($"{precentSectorG:f2}%");
            Console.WriteLine($"{precentAllStadium:f2}%");


        }
    }
}
