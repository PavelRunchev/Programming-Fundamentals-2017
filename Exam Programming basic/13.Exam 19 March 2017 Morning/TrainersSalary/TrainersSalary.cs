using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary
{
    class TrainersSalary
    {
        static void Main()
        {
            var numberOfLecture = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var Roli = 0;
            var Trofon = 0;
            var Sino = 0;
            var Jelev = 0;
            var RoYaL = 0;
            var Others = 0;
            for (int i = 0; i < numberOfLecture; i++)
            {
                var lecturer = Console.ReadLine();
                if(lecturer == "Jelev")
                    Jelev++;
                else if(lecturer == "RoYaL")
                    RoYaL++;
                else if(lecturer == "Roli")
                    Roli++;
                else if(lecturer == "Trofon")
                    Trofon++;
                else if(lecturer == "Sino")
                    Sino++;
                else
                    Others++;
            }
            var salaryForJelev = (budget / numberOfLecture) * (double)Jelev;
            var salaryForRoYaL = (budget / numberOfLecture) * (double)RoYaL;
            var salaryForRoli = (budget / numberOfLecture) * (double)Roli;
            var salaryForTrofon = (budget / numberOfLecture) * (double)Trofon;
            var salaryForSino = (budget / numberOfLecture) * (double)Sino;
            var salaryForOthers = (budget / numberOfLecture) * (double)Others;

            Console.WriteLine($"Jelev salary: {salaryForJelev:f2} lv");
            Console.WriteLine($"RoYaL salary: {salaryForRoYaL:f2} lv");
            Console.WriteLine($"Roli salary: {salaryForRoli:f2} lv");
            Console.WriteLine($"Trofon salary: {salaryForTrofon:f2} lv");
            Console.WriteLine($"Sino salary: {salaryForSino:f2} lv");
            Console.WriteLine($"Others salary: {salaryForOthers:f2} lv");
        }
    }
}
