using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch(); // 00:00:00
            stopwatch.StartTimer();
            for (int i = 0; stopwatch.IsRunning; i++)
            {
                Console.WriteLine("Press Enter each time to get current duration");
                // Display every 1s
                Thread.Sleep(1_000);
                Console.Write("Type quit or q to exit:");
                var input = Console.ReadLine().ToLower().Trim();
                //getting stopwatch time here..
                stopwatch.Interval();

                if (String.Equals("quit", input) || input.Equals("q"))
                {
                    stopwatch.EndTimer();
                }

            }

            Console.WriteLine("Exited program");
            Console.WriteLine("Final duration: {0}", stopwatch.Duration);
        }
    }
}
