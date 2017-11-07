using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmail
{
    class FixEmails
    {
        static void Main()
        {
            var dataEmals = new Dictionary<string, string>();

            
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                if (!email.Contains(".us") && !email.Contains(".uk"))
                {
                    if (!dataEmals.ContainsKey(input))
                    {
                        dataEmals.Add(input, email);
                    }
                }
            }

            foreach (var nameAndEmails in dataEmals)
            {
                Console.WriteLine($"{nameAndEmails.Key} -> {nameAndEmails.Value}");
            }
        }
    }
}
