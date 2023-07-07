public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Records a completion of the event
    public override void RecordEvent()
    {
        // Increase the number of times this goal was completed
        _amountCompleted += 1;

        // If reached the target number of times, award a bonus
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"For completing this goal, you earned a bonus of {_bonus} points!");
            SetGoalPoints(GetGoalPoints() + _bonus);
        }

        // Award normal amount of points for any completion above the target
        else if (_amountCompleted > _target)
        {
            SetGoalPoints(GetGoalPoints() - _bonus);
        }

        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
    }

    // Returns whether or not the goal is completed
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
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
        if (_amountCompleted >= _target)
        {
            isComplete = "X";
        }
        return $"[{isComplete}] {GetGoalName()} ({GetGoalDescription()} -- Currently completed: {_amountCompleted}/{_target})";
    }

    // Returns a string formatted so the program can save and load goals easily
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }

    // Sets the amount completed for the goal
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}