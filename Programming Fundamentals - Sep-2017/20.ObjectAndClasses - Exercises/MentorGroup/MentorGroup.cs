using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MentorGroup
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
    class MentorGroup
    {
        static void Main()
        {
            List<Student> dataStudents = new List<Student>();

            string inputUser = Console.ReadLine();
            while(inputUser != "end of dates")
            {
                string[] tokens = inputUser.Split(' ', ',');
                string user = tokens[0];
                List<DateTime> date = tokens.Skip(1)
                    .Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .ToList();
                if (!dataStudents.Any(f => f.Name == user))
                {
                    Student student = new Student();
                    student.Name = user;                    
                    student.Dates = new List<DateTime>();                   
                    student.Comments = new List<string>();
                    student.Dates = date;
                    dataStudents.Add(student);
                }
                else
                {
                    var addDate = dataStudents.FirstOrDefault(a => a.Name == user);
                    foreach (var d in date)
                    {
                        addDate.Dates.Add(d);
                    }
                }
               
                inputUser = Console.ReadLine();
            }

            string inputComments = Console.ReadLine();
            while(inputComments != "end of comments")
            {
                string[] tokenComments = inputComments.Split('-');
                string userComment = tokenComments[0];
                string comment = tokenComments[1];
                if(dataStudents.Any(a => a.Name == userComment))
                {
                    var addComment = dataStudents.FirstOrDefault(s => s.Name == userComment);
                    addComment.Comments.Add(comment);
                }

                inputComments = Console.ReadLine();
            }

            var orderedStudents = dataStudents
                .OrderBy(n => n.Name)
                .ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine($"Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date.ToString(@"dd/MM/yyyy")}");
                }
            }
        }
    }
}
