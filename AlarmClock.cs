using System;

namespace HomeWork_4;

public class AlarmClock
{
    private readonly int _alarmHour;
    private readonly int _alarmMinute;
    private readonly TimeUnit _minutes;
    private readonly TimeUnit _hours;
    private bool _hasTriggered = false;

    public AlarmClock(int hour, int minute, TimeUnit minutes, TimeUnit hours)
    {
        _alarmHour = hour;
        _alarmMinute = minute;
        _minutes = minutes;
        _hours = hours;
    }

    public void CheckAlarm()
    {
        if (_hours.value == _alarmHour && _minutes.value == _alarmMinute && !_hasTriggered)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n⏰ BEEP BEEP! Alarm Triggered! ⏰");
            Console.ResetColor();
            _hasTriggered = true;
        }

        if (_minutes.value != _alarmMinute)
        {
            _hasTriggered = false;
        }
    }
}