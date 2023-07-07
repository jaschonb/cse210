public class SimpleGoal : Goal
{
    // Stores whener or not the goal has been completed
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {
        // Creating a new goal defaults to goal being completed to false
        _isComplete = false;
    }

    // Completes the goal
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        _isComplete = true;
    }

    // Returns whether or not the goal is complete
    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Returns a string of the goal's details
    public override string GetDetailsString()
    {
        string isComplete = " ";
        if (_isComplete)
        {
            isComplete = "X";
        }
        return $"[{isComplete}] {GetGoalName()} ({GetGoalDescription()})";
    }

    // Returns a string formatted so the program can save and load goals easily
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{IsComplete()}";
    }

    // Sets goal completion to true or false
    public void SetCompletion(bool isComplete)
    {
        _isComplete = isComplete;
    }
}