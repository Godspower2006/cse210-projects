using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // distance in miles (1 lap = 50 meters, 1000 meters = 1 km, 1 km = 0.62 miles)
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (Minutes / 60.0);
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}
