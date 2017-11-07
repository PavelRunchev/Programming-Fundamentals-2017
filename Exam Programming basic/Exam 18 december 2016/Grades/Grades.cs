using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main()
        {
            var numberStudents = int.Parse(Console.ReadLine());

            var averageGrade = 0.0;
            var fail = 0;
            var top = 0;
            var averageTop = 0;
            var middle = 0;
            for (int i = 0; i < numberStudents; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                if(grade >= 2.00 && grade <= 2.99)
                {
                    fail++;
                }
                else if(grade >= 3.00 && grade <= 3.99)
                {
                    middle++;
                }
                else if(grade >= 4.00 && grade <= 4.99)
                {
                    averageTop++;
                }
                else if(grade >= 5.00)
                {
                    top++;
                }
                averageGrade += grade;
            }
            var precentTop = (double)top / numberStudents * 100.0;
            var precentAverageTop = (double)averageTop / numberStudents * 100.0;
            var precentMiddle = (double)middle / numberStudents * 100.0;
            var precentFail = (double)fail / numberStudents * 100.0;
            var average = averageGrade / numberStudents;

            Console.WriteLine($"Top students: {precentTop:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {precentAverageTop:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {precentMiddle:f2}%");
            Console.WriteLine($"Fail: {precentFail:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
