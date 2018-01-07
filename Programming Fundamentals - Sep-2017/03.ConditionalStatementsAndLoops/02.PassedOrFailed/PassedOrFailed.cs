using System;

namespace PassedOrFailed
{
    class PassedOrFailed
    {
        static void Main()
        {
            Console.WriteLine(double.Parse(Console.ReadLine()) >= 3.00 ? "Passed!" : "Failed!");
        }
    }
}
