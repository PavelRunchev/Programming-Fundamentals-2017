using System;

namespace BPM_Counter
{
    class BPMCounter
    {
        static void Main()
        {
            var bpm = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var bars = Math.Round(length / 4.0, 1);
            double allSeconds = (60 / bpm) * length;
            var minute = (int)(allSeconds / 60);
            var second = (int)(allSeconds % 60);
            Console.WriteLine($"{bars} bars - {minute}m {second}s");
        }
    }
}
