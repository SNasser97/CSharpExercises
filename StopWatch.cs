using System;

namespace Exercises
{
    public class StopWatch
    {
        // Exercise create a stop watch
        // Job is to simulate stopwatch behaviour. 2 Methods.
        // method 1 -> start
        // method 2 -> stop
        // Ask Duration of time between start/stop -> TIMESPAN
        // Able to use this stop watch many times
        // so start/stop then start/stop. Cannot start twice! - throw error exception

        private static int _numTimesInvoked = 0;
        public bool IsRunning { get; private set; }
        private DateTime _timer;
        public DateTime CurrentTime { get; private set; }
        public TimeSpan Duration { get; private set; }
        public DateTime Timer
        {
            get { return _timer; }
            set { _timer = value; }
        }

        public void StartTimer()
        {
            IsRunning = true;
            // new timer each time method is called
            // reset timespan when method recalled
            Timer = DateTime.Now;
            Duration = new TimeSpan(0,0,0);
            // Can only invoke start once
            HandleInvoke(_numTimesInvoked += 1);
        }

        static void HandleInvoke(int calls)
        {
            if (calls > 1)
                throw new InvalidOperationException("Cannot invoke start twice!");
        }        

        public void Interval()
        {
            CurrentTime = DateTime.Now;
            Duration = CurrentTime - Timer;
            Console.WriteLine("Duration: {0}", Duration);
        }

        public void EndTimer()
        {
            IsRunning = false;
            // Reset as start/stop should allow starting again.
            HandleInvoke(_numTimesInvoked = 0);
        }


    }
}
