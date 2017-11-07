using System;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int min = hours * 60;
            long sec = (long)min * 60;
            ulong millisec = (ulong)sec * 1000;
            decimal microsec = millisec * 1000m;
            decimal nanosec = microsec * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries, years, days, hours, min, sec, millisec, microsec, nanosec);
        }
    }
}
