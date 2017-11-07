using System;

namespace OddNumber
{
    class OddNumber
    {
        static void Main()
        {          
            while (true)
            {               
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    int number = Math.Abs(input);
                
                    if (number % 2 == 1)
                    {
                        Console.WriteLine($"The number is: {number}");
                        return;
                    }
                    Console.WriteLine("Please write an odd number.");
                }
                catch
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }             
        }
    }
}
