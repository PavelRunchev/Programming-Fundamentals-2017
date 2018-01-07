using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main()
        {
            var dataParticipants = new Dictionary<string, HashSet<string>>();
            List<string> participants = Console.ReadLine().Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> singers = Console.ReadLine()
                .Split(new string[] { ", "},
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] inputPerformance = Console.ReadLine()
                .Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries);
            while (inputPerformance[0] != "dawn")
            {
                string participant = inputPerformance[0];
                string singer = inputPerformance[1];
                string award = inputPerformance[2];
                if (participants.Contains(participant))
                {
                    if (singers.Contains(singer))
                    {
                        if (!dataParticipants.ContainsKey(participant))
                        {
                            dataParticipants.Add(participant, new HashSet<string>());
                        }
                        dataParticipants[participant].Add(award);
                    }
                }
                inputPerformance = Console.ReadLine()
                    .Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries);
            }
            
            if (dataParticipants.Values.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            var sortedParticipants = dataParticipants
                .OrderByDescending(f => f.Value.Count)
                .ThenBy(r => r.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var name in sortedParticipants)
            {
                string participant = name.Key;
                List<string> listAwards = name.Value.Distinct().OrderBy(x => x).ToList();
                Console.WriteLine($"{participant}: {listAwards.Count} awards");
                foreach (var award in listAwards)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
