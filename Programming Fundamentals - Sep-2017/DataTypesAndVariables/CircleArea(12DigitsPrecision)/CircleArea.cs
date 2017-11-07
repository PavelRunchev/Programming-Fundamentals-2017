using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea_12DigitsPrecision_
{
    class CircleArea
    {
        static void Main()
        {
            Console.WriteLine($"{Math.Pow(double.Parse(Console.ReadLine()), 2) * Math.PI:f12}");
        }
    }
}
