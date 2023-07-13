public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string activity, string date, double duration, double distance)
    : base(activity, date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return double.Round((_distance / GetDuration()), 2);
    }

    public override double GetPace()
    {
        return (double.Round(60 / GetSpeed(), 2));
    }
}