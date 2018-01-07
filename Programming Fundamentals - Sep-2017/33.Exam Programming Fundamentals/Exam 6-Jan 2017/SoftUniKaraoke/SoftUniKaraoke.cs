using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main()
        {
            var dataParticipants = new Dictionary<string, List<string>>();
            var inputParticipants = Console.ReadLine()
                .Split(new string[] { ", "},
                StringSplitOptions.RemoveEmptyEntries);
            var inputSongs = Console.ReadLine()
                .Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries);

            string inputCommands;
            while((inputCommands = Console.ReadLine()) != "dawn")
            {
                var tokens = inputCommands.Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string song = tokens[1];
                string award = tokens[2];
                if(inputParticipants.Contains(name) && inputSongs.Contains(song))
                {
                    if (dataParticipants.ContainsKey(name) 
                        && dataParticipants[name].Contains(award))
                    {
                        continue;
                    }
                    else
                    {
                        if (!dataParticipants.ContainsKey(name))
                        {
                            dataParticipants.Add(name, new List<string>());
                        }
                        dataParticipants[name].Add(award);
                    }                
                }
            }

            var sortedAwards = dataParticipants
                .OrderByDescending(d => d.Value.Count)
                .ThenBy(a => a.Key)
                .ToDictionary(k => k.Key, v => v.Value);
            if(sortedAwards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }
            foreach (var participant in sortedAwards)
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                foreach (var award in participant.Value.OrderBy(f => f))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
