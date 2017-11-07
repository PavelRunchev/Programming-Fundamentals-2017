using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main()
        {
            var websites = int.Parse(Console.ReadLine());
            var securityKey = BigInteger.Parse(Console.ReadLine());

            List<string> dataWebsites = new List<string>();
            var totalLoss = 0m;
            for (int i = 0; i < websites; i++)
            {
                string[] inputData = Console.ReadLine().Split(' ');
                string website = inputData[0];
                var siteVisit = decimal.Parse(inputData[1]);
                var pricePerVisit = decimal.Parse(inputData[2]);
                totalLoss += siteVisit * pricePerVisit;
                dataWebsites.Add(website);
            }

            Console.WriteLine(string.Join("\n", dataWebsites));
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, websites)}");
        }
    }
}
