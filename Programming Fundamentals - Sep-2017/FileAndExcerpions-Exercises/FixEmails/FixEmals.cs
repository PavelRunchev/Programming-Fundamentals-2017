using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FixEmails
{
    class FixEmals
    {
        static void Main()
        {
            var dataEmails = new Dictionary<string, string>();
            string inputFilePath = "..\\..\\input.txt";
            string[] input = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < input.Length; i+= 2)
            {
                string name = input[i];
                if(name == "stop")
                {
                    break;
                }
                string email = input[i + 1];
                if(!email.EndsWith(".us") && !email.EndsWith(".uk"))
                {
                    if (!dataEmails.ContainsKey(name))
                    {
                        dataEmails.Add(name, null);
                    }
                    dataEmails[name] = email;
                }
            }

            File.WriteAllText("..\\..\\output.txt", string.Empty);
            foreach (var fixedEmail in dataEmails)
            {
                string output = $"{fixedEmail.Key} -> {fixedEmail.Value}";
                File.AppendAllText("..\\..\\output.txt", output + Environment.NewLine);
            }
        }
    }
}
