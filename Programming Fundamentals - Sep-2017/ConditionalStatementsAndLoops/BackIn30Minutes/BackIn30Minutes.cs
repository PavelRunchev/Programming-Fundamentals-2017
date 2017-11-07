using System;

namespace BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 30;

            if(minute > 59)
            {
                hour++;
                minute -= 60;
            }
            if(hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine(minute < 10 ? $"{hour}:{minute:D2}" : $"{hour}:{minute}");
        }
    }
}
