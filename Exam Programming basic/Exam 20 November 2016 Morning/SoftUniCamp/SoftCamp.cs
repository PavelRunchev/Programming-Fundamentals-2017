using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class SoftCamp
    {
        static void Main()
        {
            var numberGroup = int.Parse(Console.ReadLine());
            var car = 0;
            var miniBus = 0;
            var smallBus = 0;
            var bus = 0;
            var train = 0;
            var countPeople = 0;
            for (int i = 0; i < numberGroup; i++)
            {
                var group = int.Parse(Console.ReadLine());
                if(group <= 5)
                {
                    car += group;
                }
                else if(group <= 12)
                {
                    miniBus += group;
                }
                else if(group <= 25)
                {
                    smallBus += group;
                }
                else if(group <= 40)
                {
                    bus += group;
                }
                else if(group >= 41)
                {
                    train += group;
                }
                countPeople += group;
            }
            Console.WriteLine($"{(double)car / countPeople * 100.0:f2}%");
            Console.WriteLine($"{(double)miniBus / countPeople * 100.0:f2}%");
            Console.WriteLine($"{(double)smallBus / countPeople * 100.0:f2}%");
            Console.WriteLine($"{(double)bus / countPeople * 100.0:f2}%");
            Console.WriteLine($"{(double)train / countPeople * 100.0:f2}%");
        }
    }
}
