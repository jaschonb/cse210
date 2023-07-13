public abstract class Activity
{
    private string _activity;
    private string _date;
    private double _duration;

    public Activity(string activity, string date, double duration)
    {
        _activity = activity;
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_activity} ({_duration} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

    public double GetDuration()
    {
        return _duration / 60;
    }
}