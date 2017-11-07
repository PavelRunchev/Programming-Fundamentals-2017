using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }

    class StudentGroups
    {
        static void Main()
        {
            List<Town> towns = ReadTownAndStudents();
            List<Group> groups = DistributeStudentsIntoGroups(towns);
            Print(groups);
        }

        private static void Print(List<Group> groups)
        {
            List<Town> countTowns = groups.Select(t => t.Town).Distinct().ToList();
            Console.WriteLine($"Created {groups.Count} groups in {countTowns.Count} towns:");
            List<Group> orderedGroups = groups.OrderBy(o => o.Town.Name).ToList();

            foreach (var group in orderedGroups)
            {
                List<string> listStudents = group.Students.Select(s => s.Email).ToList();
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", listStudents)}");               
            }
        }

        static List<Town> ReadTownAndStudents()
        {
            var towns = new List<Town>();
            string input = Console.ReadLine();
            string nameTown = string.Empty;
            while (input != "End")
            {
                if(input.Contains(" => "))
                {
                    string[] tokens = input
                        .Split(new string[] { " => ", },
                        StringSplitOptions.RemoveEmptyEntries);
                    nameTown = tokens[0];
                    string[] param = tokens[1].Split(' ');
                    int seats = int.Parse(param[0]);
                    Town town = new Town();
                    town.Name = nameTown;
                    town.SeatCount = seats;
                    town.Students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    string[] tokensStudents = input
                        .Split(new string[] { "|", },
                        StringSplitOptions.RemoveEmptyEntries);
                    string nameStudent = tokensStudents[0].Trim();
                    string email = tokensStudents[1].Trim();
                    DateTime date = DateTime.ParseExact(tokensStudents[2].Trim(),
                        "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    Student student = new Student();
                    student.Name = nameStudent;
                    student.Email = email;
                    student.RegistrationDate = date;
                    var lastTown = towns.LastOrDefault(t => t.Name == nameTown);
                    lastTown.Students.Add(student);
                }
                input = Console.ReadLine();
            }
            return towns;
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();
            foreach (var town in towns)
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(s => s.RegistrationDate)
                    .ThenBy(n => n.Name)
                    .ThenBy(e => e.Email);
                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatCount).ToList();
                    students = students.Skip(group.Town.SeatCount);
                    groups.Add(group);
                }                 
            }
            
            return groups;
        }
    }
}
