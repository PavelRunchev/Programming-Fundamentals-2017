using System;

namespace CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var count = 0;
            while (true)
            {
                int num;
                if(int.TryParse(input, out num))
                {
                    count++;
                }
                else
                {
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(count);
        }
    }
}
