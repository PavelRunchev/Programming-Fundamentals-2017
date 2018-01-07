using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class HornetComm
    {
        static void Main()
        {
            var dataMessage = new List<KeyValuePair<string, string>>();
            var dataBroadcast = new List<KeyValuePair<string, string>>();
            string privateMessagePattern = @"^(?<firstMessageQuery>\d+) <-> (?<secondMessageQuery>[A-Za-z0-9]+)$";
            string broadCastPattern = @"^(?<firstBroadcast>[^\d]*) <-> (?<secondBroadcast>[A-Za-z\d]+)$";
            Regex massageRegex = new Regex(privateMessagePattern);
            Regex broadcastRegex = new Regex(broadCastPattern);
            string input;
            while ((input = Console.ReadLine()) != "Hornet is Green")
            {

                Match matchedMessage = massageRegex.Match(input);
                Match matchBroadcast = broadcastRegex.Match(input);
                string firstQuery = string.Empty;
                string secondQuery = string.Empty;
                if (matchedMessage.Success)
                {
                    firstQuery = new string((matchedMessage.Groups["firstMessageQuery"].Value.Reverse().ToArray()));
                    secondQuery = matchedMessage.Groups["secondMessageQuery"].Value;
                    dataMessage.Add(new KeyValuePair<string, string> (firstQuery , secondQuery ));

                }
                else if (matchBroadcast.Success)
                {
                    firstQuery = matchBroadcast.Groups["firstBroadcast"].Value;
                    secondQuery = matchBroadcast.Groups["secondBroadcast"].Value;
                    secondQuery = CheckForLetter(secondQuery);
                    dataBroadcast.Add(new KeyValuePair<string, string>(secondQuery, firstQuery));
                }
            }

            Print(dataMessage, dataBroadcast);
        }

        private static string CheckForLetter(string secondQuery)
        {
            string query = string.Empty;
            for (int i = 0; i < secondQuery.Length; i++)
            {
                if (char.IsLower(secondQuery[i]))
                {
                    query += secondQuery[i].ToString().ToUpper();
                }
                else if (char.IsUpper(secondQuery[i]))
                {
                    query += secondQuery[i].ToString().ToLower();
                }
                else
                {
                    query += secondQuery[i];
                }
            }
            return query;
        }

        private static void Print(List<KeyValuePair<string, string>> dataMessage, List<KeyValuePair<string, string>> dataBroadcast)
        {
            Console.WriteLine("Broadcasts:");
            if(dataBroadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in dataBroadcast)
                {
                    Console.WriteLine($"{broadcast.Key} -> {broadcast.Value}");
                }
            }            

            Console.WriteLine("Messages:");
            if(dataMessage.Count == 0)
            {
                Console.WriteLine("None");
                return;
            }
            foreach (var message in dataMessage)
            {
                Console.WriteLine($"{message.Key} -> {message.Value}");
            }
        }
    }
}
