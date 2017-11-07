using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class User
    {
        public string Name { get; set; }
        public Dictionary<string, int> Ip { get; set; }
    }
    class UserLogs
    {
        static void Main()
        {
            var dataLogs = new List<User>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                int indexIp = tokens[0].IndexOf("=");
                string ip = tokens[0].Substring(indexIp + 1);
                int indexUser = tokens[2].IndexOf("=");
                string user = tokens[2].Substring(indexUser + 1);

                if (!dataLogs.Any(n => n.Name == user))
                {
                    User userLog = new User();
                    userLog.Name = user;
                    userLog.Ip = new Dictionary<string, int>();
                    userLog.Ip.Add(ip, 1);
                    dataLogs.Add(userLog);
                }
                else
                {
                    int index = dataLogs.IndexOf(dataLogs.Find(c => c.Name == user));
                    if (dataLogs[index].Ip.ContainsKey(ip))
                    {
                        dataLogs[index].Ip[ip]++;
                    }
                    else
                    {
                        dataLogs[index].Ip.Add(ip, 1);
                    }
                }

                input = Console.ReadLine();
            }

            dataLogs = dataLogs
                .OrderBy(name => name.Name)
                .ToList();

            foreach (var user in dataLogs)
            {
                Console.WriteLine($"{user.Name}: ");

                bool isComma = false;
                foreach (var ipAndCount in user.Ip)
                {
                    if (isComma)
                    {
                        Console.Write($", {ipAndCount.Key} => {ipAndCount.Value}");
                    }
                    else
                    {
                        Console.Write($"{ipAndCount.Key} => {ipAndCount.Value}");
                        isComma = true;
                    }
                }
                Console.Write(".");
                Console.WriteLine();
            }
        }
    }
}
