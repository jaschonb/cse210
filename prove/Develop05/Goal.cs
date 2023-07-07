public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetGoalName()
    {
        return _shortName;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public int GetGoalPoints()
    {
        return _points;
    }

    public void SetGoalPoints(int points)
    {
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
}