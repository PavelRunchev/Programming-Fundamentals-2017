using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
    class AverageGrades
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            int numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Student student = new Student();
                student.Name = input[0];
                student.Grades = input.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }

            var orderedStudents = students
                .Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(a => a.AverageGrade)
                .ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}
