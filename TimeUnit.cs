using System;

namespace HomeWork_4;

public class TimeUnit(string name, int maxValue)
{
    public string Name { get; init; } = name;
    public int value { get; private set; } = 0;
    public int maxValue { get; init; } = maxValue;

    public event EventHandler<TimeReport> ValueChanged;
    public event EventHandler LimitReached;

    public void SetValue(int newValue)
    {
        if (newValue >= 0 && newValue < maxValue)
        {
            value = newValue;
            ValueChanged?.Invoke(this, new TimeReport(value));
        }
    }

    public void AddTime(int time)
    {
        value += time;
        ValueChanged?.Invoke(this, new TimeReport(value));
        if (value >= maxValue)
        {
            value = 0;
            LimitReached?.Invoke(this, EventArgs.Empty);
        }
    }

    public void Tic()
    {
        AddTime(1);
    }

    public override string ToString()
    {
        return value.ToString("D2");
    }
}