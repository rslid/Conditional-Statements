using System;


public static class TimeExtensions
{
    public static bool IsBetween(this DateTime now, DateTime startTime, DateTime endTime)
    {
        if (now.TimeOfDay == startTime.TimeOfDay) return true;
        if (now.TimeOfDay == endTime.TimeOfDay) return true;

        if (startTime.TimeOfDay <= endTime.TimeOfDay)
            return (now.TimeOfDay >= startTime.TimeOfDay && now.TimeOfDay <= endTime.TimeOfDay);
        else
            return (now.TimeOfDay >= startTime.TimeOfDay || now.TimeOfDay <= endTime.TimeOfDay);
    }


}


