public class SwimmingActivity : Activity
{
    private double _numberOfLaps;

    public SwimmingActivity(string activity, string date, double duration, double numberOfLaps)
    : base(activity, date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return double.Round(_numberOfLaps * 50 / 1000 * 0.62, 2);
    }

    public override double GetSpeed()
    {
        return double.Round(GetDistance() / GetDuration(), 2);
    }

    public override double GetPace()
    {
        return double.Round(60 / GetSpeed(), 2);
    }
}