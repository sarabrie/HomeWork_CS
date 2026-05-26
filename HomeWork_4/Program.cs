using System;
using System.Threading;

namespace HomeWork_4;

class Program
{
    static void Main()
    {
        TimeUnit seconds = new TimeUnit("Seconds", 60);
        TimeUnit minutes = new TimeUnit("Minutes", 60);
        TimeUnit hours = new TimeUnit("Hours", 24);

        hours.SetValue(10);
        minutes.SetValue(59);
        seconds.SetValue(57);

        seconds.LimitReached += (sender, e) => minutes.Tic();
        minutes.LimitReached += (sender, e) => hours.Tic();

        AlarmClock alarm = new AlarmClock(11, 0, minutes, hours);

        Display clockDisplay = new Display(seconds, minutes, hours, alarm);

        while (true)
        {
            seconds.Tic();
            Thread.Sleep(1000);
        }
    }
}