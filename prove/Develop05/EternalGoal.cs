public class EternalGoal : Goal
{   
    public EternalGoal(string name, string description, int points)
    : base(name, description, points) {}

    // Tells the user how many points were earned, but doesn't complete the goal
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
    }

    // Returns false because these goals can never be completed
    public override bool IsComplete()
    {
        return false;
    }

    // Returns a string of the goal's details
    public override string GetDetailsString()
    {
        return $"[ ] {GetGoalName()} ({GetGoalDescription()})";
    }

    // Returns a string formatted so the program can save and load goals easily
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}";
    }
}