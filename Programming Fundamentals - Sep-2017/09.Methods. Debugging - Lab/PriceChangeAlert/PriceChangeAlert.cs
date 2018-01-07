using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double limit = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = GetOercent(lastPrice, currentPrice);
                bool isSignificantDifference = GetDifference(difference, limit);

                string message = GetMessage(currentPrice, lastPrice, difference, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string GetMessage(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
        {
            string inCase = string.Empty;
            if (difference == 0)
            {
                inCase = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!etherTrueOrFalse)
            {
                inCase = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                inCase = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference < 0))
                inCase = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            return inCase;
        }
        private static bool GetDifference(double difference, double limit)
        {
            if (Math.Abs(difference) >= limit)
            {
                return true;
            }
            return false;
        }

        private static double GetOercent(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;
            return result;
        }
    }
}
    

