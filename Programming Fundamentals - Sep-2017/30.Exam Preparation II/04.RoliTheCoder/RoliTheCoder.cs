using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main()
        {
            var dataEvents = new Dictionary<int, Dictionary<string, HashSet<string>>>();
            var input = Console.ReadLine();
            while(input != "Time for Code")
            {
                var tokens = input
                    .Split(new char[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries);

                int id = int.Parse(tokens[0]);
                string eventName = tokens[1];

                if (eventName.StartsWith("#"))
                {
                    string[] participants = tokens.Skip(2).ToArray();

                    if (isValidParticipants(participants))
                    {
                        if (!dataEvents.ContainsKey(id))
                        {
                            dataEvents.Add(id, new Dictionary<string, HashSet<string>>());
                            dataEvents[id].Add(eventName, new HashSet<string>());
                            foreach (var item in participants)
                            {
                                dataEvents[id][eventName].Add(item);
                            }
                        }
                        else if(dataEvents.ContainsKey(id) 
                            && dataEvents[id].ContainsKey(eventName))
                        {
                            foreach (var item in participants)
                            {
                                dataEvents[id][eventName].Add(item);
                            }
                        }              
                    }
                }

                input = Console.ReadLine();
            }

            PrintAllEvents(dataEvents);
        }

        private static void PrintAllEvents(Dictionary<int, Dictionary<string, HashSet<string>>> dataEvents)
        {
            var sort = dataEvents.OrderByDescending(s => s.Value.Max(v => v.Value.Count))
                      .ThenBy(f => f.Key).ToDictionary(g => g.Key, d => d.Value);
            foreach (var item in sort)
            {
                foreach (var eventName in item.Value)
                {
                    string name = eventName.Key;
                    name = name.Remove(0, 1);
                    Console.WriteLine($"{name} - {eventName.Value.Count()}");
                    foreach (var participant in eventName.Value.OrderBy(t => t))
                    {
                        Console.WriteLine($"{participant}");
                    }
                }
            }
        }

        private static bool isValidParticipants(string[] participants)
        {
            bool isValid = true;
            foreach (var item in participants)
            {
                if (item.StartsWith("@"))
                {
                    for (int i = 1; i < item.Length; i++)
                    {
                        int letter = (int)item[i];
                        if (letter == 45 || letter >= 48 || letter <= 57
                            || letter >= 65 || letter <= 90
                            || letter >= 60 || letter <= 122)
                        {
                            isValid = true;           
                        }
                        else
                        {
                            return isValid = false;           
                        }
                    }
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
}
