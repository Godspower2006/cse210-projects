using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    // Abstract methods to be overridden
    public abstract double GetDistance();  // in miles
    public abstract double GetSpeed();     // in mph
    public abstract double GetPace();      // in min per mile

    // Virtual summary method
    public virtual string GetSummary()
    {
        string dateStr = _date.ToString("dd MMM yyyy");
        return $"{dateStr} {this.GetType().Name} ({_minutes} min) - Distance {GetDistance():0.0} mi, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
