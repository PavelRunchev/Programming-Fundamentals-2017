using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class UserLogs
    {
        static void Main()
        {
           var dataUsers = new Dictionary<string, Dictionary<string, int>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                string ip = tokens[0]
                    .Split(new string[] { "IP=" },
                    StringSplitOptions.RemoveEmptyEntries).First();
                string user = tokens[2].Split(new string[] { "user=" },
                    StringSplitOptions.RemoveEmptyEntries).First();
                if (!dataUsers.ContainsKey(user))
                {
                    dataUsers.Add(user, new Dictionary<string, int>());
                }
                if (!dataUsers[user].ContainsKey(ip))
                {
                    dataUsers[user].Add(ip, 0);
                }
                dataUsers[user][ip]++;
            }

            foreach (var user in dataUsers.OrderBy(name => name.Key))
            {
                string userName = user.Key;
                Console.WriteLine($"{userName}:");
                int count = 0;
                foreach (var ip in user.Value)
                {
                    ++count;
                    if(count != user.Value.Count)
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }                   
                }
            }
        }
    }
}
