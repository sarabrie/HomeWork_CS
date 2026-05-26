using System;

namespace HomeWork_4;

public class TimeReport : EventArgs
{
    public int CurrentValue { get; }

    public TimeReport(int currentValue)
    {
        CurrentValue = currentValue;
    }
}