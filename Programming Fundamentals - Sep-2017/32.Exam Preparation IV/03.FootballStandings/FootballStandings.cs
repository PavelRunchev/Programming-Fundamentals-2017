using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FootballStandings
{
    class Team
    {
        public long Score { get; set; }
        public long Goals { get; set; }
    }
    class FootballStandings
    {
        static void Main()
        {
            var dataTeams = new Dictionary<string, Team>();
            string key = Regex.Escape(Console.ReadLine());
            string pattern = $@"^.*(?:{key})(?<team1>[A-Za-z]*)(?:{key}).* .*(?:{key})(?<team2>[A-Za-z]*)(?:{key}).* (?<team1Score>\d+):(?<team2Score>\d+).*$";

            string input;
            while ((input = Console.ReadLine()) != "final")
            {
                Regex regex = new Regex(pattern);
                Match matchedInput = regex.Match(input);

                string firstTeam = new string(matchedInput.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                string secondTeam = new string(matchedInput.Groups["team2"].Value.ToUpper().Reverse().ToArray());

                long firstScore = long.Parse(matchedInput.Groups["team1Score"].Value);
                long secondScore = long.Parse(matchedInput.Groups["team2Score"].Value);

                long addFirstPoints = GetPoints(firstScore, secondScore);
                long addSecondPoints = GetPoints(secondScore, firstScore);

                if (!dataTeams.ContainsKey(firstTeam))
                {
                    dataTeams.Add(firstTeam, new Team());
                }
                dataTeams[firstTeam].Goals += firstScore;
                dataTeams[firstTeam].Score += addFirstPoints;

                if (!dataTeams.ContainsKey(secondTeam))
                {
                    dataTeams.Add(secondTeam, new Team());
                }
                dataTeams[secondTeam].Goals += secondScore;
                dataTeams[secondTeam].Score += addSecondPoints;
            }

            PrintStandingsTable(dataTeams);
        }

        private static void PrintStandingsTable(Dictionary<string, Team> dataTeams)
        {
            var sortedTeamsbyScores = dataTeams
                .OrderByDescending(s => s.Value.Score)
                .ThenBy(d => d.Key)
                .ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine("League standings:");
            int count = 1;
            foreach (var team in sortedTeamsbyScores)
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value.Score}");
                count++;
            }

            var getTop3TeamsByGoals = dataTeams
                .OrderByDescending(e => e.Value.Goals)
                .ThenBy(r => r.Key)
                .Take(3)
                .ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine("Top 3 scored goals:");
            foreach (var topGoals in getTop3TeamsByGoals)
            {
                Console.WriteLine($"- {topGoals.Key} -> {topGoals.Value.Goals}");
            }
        }

        private static long GetPoints(long firstScore, long secondScore)
        {
            long point = 1;
            if (firstScore > secondScore)
            {
                point = 3;
            }
            else if (firstScore < secondScore)
            {
                point = 0;
            }
            return point;
        }
    }
}
