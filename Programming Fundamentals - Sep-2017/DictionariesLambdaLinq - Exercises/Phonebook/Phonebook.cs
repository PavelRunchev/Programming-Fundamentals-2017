using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            var phonebook = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(' ').ToArray();
                string command = tokens[0];
                string name = tokens[1];
                if(command == "A")
                {
                    string phone = tokens[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, null);
                    }
                    phonebook[name] = phone;
                }
                else if(command == "S")
                {
                    string number;
                    if (phonebook.TryGetValue(name, out number))
                    {
                        Console.WriteLine($"{name} -> {number}");
                    }
                    else if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
