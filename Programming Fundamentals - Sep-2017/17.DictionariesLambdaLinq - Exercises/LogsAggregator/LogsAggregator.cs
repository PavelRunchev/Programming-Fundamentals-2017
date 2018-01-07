using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class UserLogs
    {
        public string User { get; set; }
        public int Duration { get; set; }
        public HashSet<string> Ip { get; set; }
    }
    class LogsAggregator
    {
        static void Main()
        {
            var dataUsers = new List<UserLogs>();
            int numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string ip = input[0];
                string name = input[1];
                int duration = int.Parse(input[2]);
                if(!dataUsers.Any(u => u.User == name))
                {
                    UserLogs userLog = new UserLogs();
                    userLog.User = name;
                    userLog.Duration = duration;
                    userLog.Ip = new HashSet<string>();
                    userLog.Ip.Add(ip);
                    dataUsers.Add(userLog);
                }
                else
                {
                    if(dataUsers.Any(u => u.User == name))
                    {
                        int index = dataUsers.IndexOf(dataUsers.Find(n => n.User == name));
                        dataUsers[index].Duration += duration;
                        dataUsers[index].Ip.Add(ip);
                    }
                }
            }

            var orderedUsers = dataUsers               
                .OrderBy(u => u.User)
                .ToList();

            foreach (var userName in orderedUsers)
            {
                Console.WriteLine($"{userName.User}: {userName.Duration} [{string.Join(", ", userName.Ip.Distinct().OrderBy(i => i).ToList())}]");
            }
        }
    }
}
