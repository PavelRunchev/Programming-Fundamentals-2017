using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace PunctuationFinder
{
    class PunctuationFinder
    {
        static void Main()
        {
            string[] inputText = File.ReadAllLines("..\\..\\sample_text.txt");
            char[] punctoation = new char[] { '.', ',', '!', '?', ':' };
            List<char> punctoationList = new List<char>();

            foreach (var line in inputText)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (punctoation.Contains(line[i]))
                    {
                        punctoationList.Add(line[i]);
                    }
                }
            }
            File.AppendAllText("..\\..\\output.txt", string.Join(", ", punctoationList));
        }
    }
}
