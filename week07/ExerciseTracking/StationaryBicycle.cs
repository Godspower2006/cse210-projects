using System;

public class StationaryBicycle : Activity
{
    private double _speed; // in miles per hour

    public StationaryBicycle(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // distance = speed * time in hours
        return _speed * (Minutes / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // pace = minutes per mile
        return 60.0 / _speed;
    }
}
