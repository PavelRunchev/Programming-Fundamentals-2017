using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AverageGrade
{
    class AverageGrade
    {
        static void Main()
        {
            List<Student> dataStudents = new List<Student>();

            string inputFilePath = "..\\..\\input.txt";
            File.WriteAllText("..\\..\\output.txt", string.Empty);
            List<string> input = File.ReadAllLines(inputFilePath).ToList();
            while (input.Count > 0)
            {
                int length = int.Parse(input.First());
                for (int i = 0; i < length; i++)
                {
                    string[] tokens = input[i + 1].Split(' ');
                    string name = tokens.First();
                    List<double> grades = tokens
                        .Skip(1)
                        .Select(grade => double.Parse(grade))
                        .ToList();
                    Student student = new Student();
                    student.Name = name;
                    student.Grades = new List<double>();
                    student.Grades = grades;
                    dataStudents.Add(student);
                }

                var orderedStudentByAverageGrades = dataStudents
                    .Where(g => g.Average >= 5.00)
                    .OrderBy(n => n.Name)
                    .ThenByDescending(a => a.Average)
                    .ToList();

                File.AppendAllText("..\\..\\output.txt", "Output:" + Environment.NewLine);
                foreach (var student in orderedStudentByAverageGrades)
                {
                    string output = $"{student.Name} -> {student.Average:f2}";
                    File.AppendAllText("..\\..\\output.txt", output + Environment.NewLine);
                }
                input.RemoveRange(0, length + 1);
                dataStudents.Clear();
            }          
        }
    }
}
