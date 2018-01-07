using System;
using System.Text;


namespace MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main()
        {
            var mile = decimal.Parse(Console.ReadLine());
            var km = 1.60934m;
            Console.WriteLine($"{mile * km:f2}");
        }
    }
}
