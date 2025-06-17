using System;

public class Running : Activity
{
    private double _distance;  // miles

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // mph = distance / hours
        return GetDistance() / (Minutes / 60.0);
    }

    public override double GetPace()
    {
        // min per mile
        return Minutes / GetDistance();
    }
} 
