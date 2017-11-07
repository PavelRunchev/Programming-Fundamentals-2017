using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СръбскоUnleashed
{
    class СръбскоUnleashed
    {
        static void Main()
        {
            var dataSingers = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while(input != "End")
            {                
                if (input.Contains(" @"))
                {
                    int index = input.IndexOf(" @");
                    string singer = input.Substring(0, index);
                    string tokens = input.Substring(index + 2);

                    string[] unleashed = tokens.Split();
                    if (unleashed.Length > 2)
                    {
                        string venue = string.Empty;
                        List<int> number = new List<int>();
                        for (int i = 0; i < unleashed.Length; i++)
                        {
                            int num;
                            if (int.TryParse(unleashed[i], out num))
                            {
                                number.Add(num);
                            }
                            else
                            {
                                venue += unleashed[i] + " ";
                            }
                        }
                        venue = venue.TrimEnd();
                        if (number.Count == 2)
                        {
                            int ticketsPrice = number[0];
                            int counts = number[1];
                            if (!dataSingers.ContainsKey(venue))
                            {
                                dataSingers.Add(venue, new Dictionary<string, long>());
                            }
                            if (!dataSingers[venue].ContainsKey(singer))
                            {
                                dataSingers[venue].Add(singer, 0);
                            }
                            dataSingers[venue][singer] += (long)(ticketsPrice * counts);
                        }               
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var venues in dataSingers)
            {
                Console.WriteLine($"{venues.Key}");
                var singers = venues.Value.
                    OrderByDescending(u => u.Value)
                    .ToDictionary(k => k.Key, v => v.Value);
                
                foreach (var solo in singers)
                {
                    Console.WriteLine($"#  {solo.Key} -> {solo.Value}");
                }
            }
        }
    }
}
