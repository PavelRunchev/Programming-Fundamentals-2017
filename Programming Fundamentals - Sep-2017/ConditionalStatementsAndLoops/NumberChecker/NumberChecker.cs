using System;

namespace NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number;
            if(int.TryParse(input, out number))
            {
                Console.WriteLine($"It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
