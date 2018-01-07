using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class PoolPipes
    {
        static void Main()
        {
            var volumePool = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var hoursOutWorker = double.Parse(Console.ReadLine());

            var pipe1Fill = pipe1 * hoursOutWorker;
            var pipe2Fill = pipe2 * hoursOutWorker;
            var allPipesFull = pipe1Fill + pipe2Fill;

            var precentFull = allPipesFull / volumePool * 100;
            var precentPipe1 = pipe1Fill / allPipesFull * 100;
            var precentPipe2 = pipe2Fill / allPipesFull * 100;

            Console.WriteLine(allPipesFull <= volumePool ? 
                $"The pool is {(int)precentFull}% full. Pipe 1: {(int)precentPipe1}%. Pipe 2: {(int)precentPipe2}%." 
                : $"For {hoursOutWorker} hours the pool overflows with {allPipesFull - (double)volumePool:f1} liters.");
        }
    }
}
