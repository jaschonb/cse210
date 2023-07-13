public class BicycleActivity : Activity
{
    private double _speed;

    public BicycleActivity(string activity, string date, double duration, double speed)
    : base(activity, date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return double.Round(_speed * GetDuration(), 2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return double.Round(60 / _speed, 2);
    }
}