using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CameraView
{
    class CameraView
    {
        static void Main()
        {
            List<string> dataElements = new List<string>();
            int[] elemnts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int skipElement = elemnts[0];
            int takeElement = elemnts[1];

            string camera = Console.ReadLine();
            string searchCamera = @"\|<\w+\b";
            var matchesElements = Regex.Matches(camera, searchCamera);

            foreach (Match element in matchesElements)
            {
                char[] view = element.ToString()
                    .Skip(2 + skipElement)
                    .Take(takeElement)
                    .ToArray();
                dataElements.Add(string.Join("", view));
            }

            Console.WriteLine(string.Join(", ", dataElements));
        }
    }
}
