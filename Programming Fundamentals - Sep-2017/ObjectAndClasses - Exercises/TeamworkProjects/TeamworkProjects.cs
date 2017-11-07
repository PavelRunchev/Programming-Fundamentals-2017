using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> TeamUsers { get; set; }

        public Team(string teamName, string creator)
        {
            this.Name = teamName;
            this.Creator = creator;
            this.TeamUsers = new List<string>();
        }
    }
    class TeamworkProjects
    {
        static void Main()
        {
            List<Team> dataTeams = CreateNewTeams();

            AddUsersInTheTeams(dataTeams);

            List<Team> disbandList = dataTeams
                .Where(a => a.TeamUsers.Count == 0)
                .OrderBy(p => p.Name)
                .ToList();
            List<Team> listTeams = dataTeams
                .Where(a => a.TeamUsers.Count > 0)
                .OrderByDescending(t => t.TeamUsers.Count)
                .ThenBy(g => g.Name)
                .ToList();

            PrintTeams(disbandList, listTeams);         
        }

        private static void PrintTeams(List<Team> disbandList, List<Team> listTeams)
        {
            foreach (var team in listTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var userTeam in team.TeamUsers.OrderBy(a => a))
                {
                    Console.WriteLine($"-- {userTeam}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var disbandTeam in disbandList)
            {
                Console.WriteLine($"{disbandTeam.Name}");
            }
        }

        private static void AddUsersInTheTeams(List<Team> dataTeams)
        {
            string inputUsers = Console.ReadLine();
            while (inputUsers != "end of assignment")
            {
                string[] tokens = inputUsers
                    .Split(new char[] { '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);
                string user = tokens[0];
                string addTeam = tokens[1];
                if (!dataTeams.Any(u => u.Name == addTeam))
                {
                    Console.WriteLine($"Team {addTeam} does not exist!");
                }
                else if (dataTeams.Any(j => j.Creator == user)
                    || (dataTeams.Any(d => d.TeamUsers.Any(w => w == user))))
                {
                    Console.WriteLine($"Member {user} cannot join team {addTeam}!");
                }
                else if (dataTeams.Any(f => f.Name == addTeam))
                {
                    var currentTeam = dataTeams.FirstOrDefault(a => a.Name == addTeam);
                    currentTeam.TeamUsers.Add(user);
                }

                inputUsers = Console.ReadLine();
            }
        }

        private static List<Team> CreateNewTeams()
        {
            List<Team> dataTeams = new List<Team>();
            int numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] inputRegisterTeam = Console.ReadLine().Split('-');
                string creator = inputRegisterTeam[0];
                string teamName = inputRegisterTeam[1];
                if (dataTeams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (dataTeams.Any(c => c.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (!dataTeams.Any(t => t.Name == teamName && t.Creator == creator))
                {
                    Team team = new Team(teamName, creator);
                    dataTeams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
            return dataTeams;
        }
    }
}
