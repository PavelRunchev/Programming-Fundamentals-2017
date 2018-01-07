using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main()
        {
            var hourExam = int.Parse(Console.ReadLine());
            var minuteExam = int.Parse(Console.ReadLine());
            var hourStudent = int.Parse(Console.ReadLine());
            var minuteStudent = int.Parse(Console.ReadLine());

            var allMinuteExam = (hourExam * 60) + minuteExam;
            var allMinuteStudent = (hourStudent * 60) + minuteStudent;
            var differenceMinute = allMinuteExam - allMinuteStudent;

            var difference = Math.Abs(differenceMinute);
            var startExam = string.Empty;
            if(differenceMinute >= 0 && differenceMinute <= 30)
            {
                Console.WriteLine("On time");
                if (difference == 0)
                    return;
                if (difference < 60)
                    startExam = "minutes before the start";             
            }
            else if(differenceMinute > 30)
            {
                Console.WriteLine("Early");
                if(difference < 60)
                    startExam = "minutes before the start";
                else
                    startExam = "hours before the start";
            }
            else if(differenceMinute < 0)
            {
                Console.WriteLine("Late");
                if (difference < 60)
                    startExam = "minutes after the start";
                else
                    startExam = "hours after the start";
            }
            TimeSpan minute = TimeSpan.FromMinutes(differenceMinute);
            if(difference < 10)
            {
                Console.WriteLine($"{difference} {startExam}");
            }
            else
            {
                Console.WriteLine(difference < 60 ? minute.ToString(@"mm") + $" {startExam}"
                : minute.ToString(@"h\:mm") + $" {startExam}");
            }
            
        }
    }
}
