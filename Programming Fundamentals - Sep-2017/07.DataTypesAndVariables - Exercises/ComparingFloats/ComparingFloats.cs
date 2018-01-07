using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double diff = Math.Abs(numberA - numberB);
            if(diff > eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
