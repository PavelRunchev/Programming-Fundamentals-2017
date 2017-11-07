using System;

namespace Elevator
{
    class Elevator
    {
        static void Main()
        {
            Console.WriteLine((int)Math.Ceiling(int.Parse(Console.ReadLine()) / (double)int.Parse(Console.ReadLine())));
        }
    }
}
