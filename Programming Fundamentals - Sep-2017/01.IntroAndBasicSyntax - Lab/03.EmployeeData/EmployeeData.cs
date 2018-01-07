using System;
using System.Text;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}\nAge: {age}\nEmployee ID: {id:d8}\nSalary: {salary:f2}");
        }
    }
}
