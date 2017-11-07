using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
    }
    class OrderByAge
    {
        static void Main()
        {
            var dataPerson = new List<Person>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            while(input[0] != "End")
            {
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);
                Person person = new Person(name, id, age);
                dataPerson.Add(person);

                input = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }

            var orderedPersons = dataPerson.OrderBy(a => a.Age).ToList();
            foreach (var person in orderedPersons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
