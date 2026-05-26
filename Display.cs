using System;

namespace HomeWork_4;

public class Display
{
    private readonly TimeUnit _seconds;
    private readonly TimeUnit _minutes;
    private readonly TimeUnit _hours;
    private readonly AlarmClock _alarm;

    public Display(TimeUnit seconds, TimeUnit minutes, TimeUnit hours, AlarmClock alarm)
    {
        _seconds = seconds;
        _minutes = minutes;
        _hours = hours;
        _alarm = alarm;

        _seconds.ValueChanged += OnTimeChanged;
        _minutes.ValueChanged += OnTimeChanged;
        _hours.ValueChanged += OnTimeChanged;
    }

    private void OnTimeChanged(object? sender, TimeReport e)
    {
        Console.Clear();

        // משנה צבע לירוק רק בשנייה 00 של דקה חדשה
        if (_seconds.value == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ResetColor();
        }

        Console.WriteLine("The Reactive Clock is running...\n");
        Console.WriteLine($"{_hours}:{_minutes}:{_seconds}");

        Console.ResetColor();

        _alarm.CheckAlarm();
    }
}