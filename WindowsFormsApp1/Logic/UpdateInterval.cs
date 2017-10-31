using System;
using System.IO;
using System.Collections.Generic;
using System.Timers;

namespace Logic
{
    public class UpdateInterval
    {
        int time;

        public UpdateInterval()
        {
            this.time = 1000;
        }


        //private static Timer aTimer;
        //private static List<String> eventlog;
        //private static int nEventsFired = 0;
        //private static DateTime previousTime;

        //public static void Main()
        //{
        //    eventlog = new List<String>();

        //    StreamWriter sr = new StreamWriter(@".\Interval.txt");
        //    // Create a timer with a five millisecond interval.
        //    aTimer = new Timer(5);
        //    aTimer.Elapsed += OnTimedEvent;
        //    // Hook up the Elapsed event for the timer. 
        //    aTimer.AutoReset = true;
        //    sr.WriteLine("The timer should fire every {0} milliseconds.",
        //                 aTimer.Interval);
        //    aTimer.Enabled = true;


        //    Console.WriteLine("Press the Enter key to exit the program... ");
        //    Console.ReadLine();
        //    foreach (var item in eventlog)
        //        sr.WriteLine(item);
        //    sr.Close();
        //    Console.WriteLine("Terminating the application...");
        //}

        //private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        //{
        //    eventlog.Add(String.Format("Elapsed event at {0:HH':'mm':'ss.ffffff} ({1})",
        //                               e.SignalTime,
        //                               nEventsFired++ == 0 ?
        //                                  0.0 : (e.SignalTime - previousTime).TotalMilliseconds));
        //    previousTime = e.SignalTime;
        //    if (nEventsFired == 20)
        //    {
        //        Console.WriteLine("No more events will fire...");
        //        aTimer.Enabled = false;
        //    }
        //}
    }
}