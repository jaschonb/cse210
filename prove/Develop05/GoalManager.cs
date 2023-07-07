public class GoalManager
{
    // A list to store each goal
    private List<Goal> _goals;

    // An integer to keep track of the user's score
    private int _score;

    // An integer to keep track of user's level
    private int _level;

    // An double to store the target score to level up
    private int _targetScore;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
        _level = 0;
        _targetScore = 100;
    }

    // Updates the user's level
    public void UpdateLevel()
    {
        // If the score is greater than the target score, level up
        if (_score >= _targetScore)
        {
            // Repeat this loop in case you earned enough points to
            // level up multiple times
            while (_score >= _targetScore)
            {
                // Subtract the points needed to level up
                _score = _score - _targetScore;

                // Increase the level
                _level += 1;

                // Update the new target score
                _targetScore = (_level + 1) * 100 + (10 * _level);
            }
            // Display a level up message
            Console.WriteLine($"You leveled up to level {_level}!");
        }
    }

    public void Start()
    {
        // The program loops until the user selects the "quit" option
        string menuChoice = "";
        while (menuChoice != "6")
        {
            // Write the menu to the console
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            // Prompt the user for a selection and save their selection
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            Console.Clear();

            // Call the method corresponding to the user's choice
            if (menuChoice == "1")
            {
                CreateGoal();
            }
            else if (menuChoice == "2")
            {
                ListGoalDetails();
            }
            else if (menuChoice == "3")
            {
                SaveGoals();
            }
            else if (menuChoice == "4")
            {
                LoadGoals();
            }
            else if (menuChoice == "5")
            {
                RecordEvent();
            }
            else if (menuChoice == "6")
            {
                return;
            }
            else
            {
                // If the user writes something other than 1-6,
                // restart saying there is an invalid selection
                Console.WriteLine("Error: Invalid selection.");
                Console.WriteLine();
            }
        }
    }

    // Displays the user's score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Level {_level}");
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"You need {_targetScore} points to level up!");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
    }

    // Lists the goal's names.
    public void ListGoalNames()
    {
        // IF the user has no goals, tell them
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals!");
            Console.WriteLine();
            return;
        }

        // Lists each goal in a numbered list
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }
        Console.WriteLine();
    }

    // Lists the names and details of each goal
    public void ListGoalDetails()
    {
        // If the user has no goals, tell them
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals!");
            Console.WriteLine();
            return;
        }

        // Lists each goal in a numbered list with details
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine();
    }

    // Creates a goal from the user
    public void CreateGoal()
    {
        // Creates a Goal object
        Goal newGoal = null;

        // Lists the types of goals for the user to pick
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        // Prompts the user to select a goal type
        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();

        // Prompts the user to name the goal
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        // Prompts the user to write a description of the goal
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        // Prompts the user for the number of points associated with the goal
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        // Creates the goal depending on which goal the user selected
        if (goalChoice == "1")
        {
            newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
        }
        else if (goalChoice == "2")
        {
            newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
        }
        else if (goalChoice == "3")
        {
            // Prompts the user for the number of times until the goal is accomplished
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalQuantity = int.Parse(Console.ReadLine());

            // Prompts the user for the number of bonus points
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalQuantity, goalBonus);
        }
        else
        {
            // If the user inputs something invalid in any of the inputs,
            // display an error message and have them try again
            Console.Clear();
            Console.WriteLine("Error: unable to process goal. Please try again");
            Console.WriteLine();
            CreateGoal();
            return;
        }
        Console.WriteLine();

        // Add the new goal to the _goals list
        _goals.Add(newGoal);
    }

    // Records an accomplishment of a goal
    public void RecordEvent()
    {
        // List all the goals for the user to select which one was accomplished
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int acompmlishedGoal = int.Parse(Console.ReadLine()) - 1;

        // Call the goal's RecordEvent() method to record it
        Console.WriteLine();
        _goals[acompmlishedGoal].RecordEvent();

        // Update the score based on thepoints the specified goal gave
        _score += _goals[acompmlishedGoal].GetGoalPoints();
        UpdateLevel();
    }

    // Saves all goals and progress to a file
    public void SaveGoals()
    {
        // Find the file that the user enters
        Console.Write("Please enter the file name: ");
        string fileName = Console.ReadLine();

        // Clear the current file to avoid duplicates
        File.WriteAllText(fileName, String.Empty);

        // Open the given file for writing
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Write the current level
            outputFile.WriteLine($"Level:{_level}");

            // Write the current score
            outputFile.WriteLine($"Score:{_score}");

            // Write the current target score
            outputFile.WriteLine($"TargetScore:{_targetScore}");

            // Write each entry to a single line in the given file
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        // Find the file that the user enters and open it for reading
        Console.Write("Please enter the file name: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        // Go through each line in the file and seperate it into the
        // goal types
        foreach (string line in lines)
        {
            string[] types = line.Split(":");
            string type = types[0];
            string data = types[1];

            // Update the level
            if (type == "Level")
            {
                _level = int.Parse(data);
            }
            // Update the score
            else if (type == "Score")
            {
                _score = int.Parse(data);
            }
            else if (type == "TargetScore")
            {
                _targetScore = int.Parse(data);
            }
            // Load a simple goal
            else if (type == "SimpleGoal")
            {
                // Split the representation string into the goal's data and create a new goal
                string[] parts = data.Split("|");
                SimpleGoal goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));

                // Record whether the goal was completed or not
                goal.SetCompletion(Convert.ToBoolean(parts[3]));

                // Add the goal to the _goals list
                _goals.Add(goal);
            }
            // Load an eternal goal
            else if (type == "EternalGoal")
            {
                // Split the representation string into the goal's data and create a new goal
                string[] parts = data.Split("|");
                EternalGoal goal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));

                // Add the goal to the _goals list
                _goals.Add(goal);
            }
            // Load a checklist goal
            else if (type == "ChecklistGoal")
            {
                // Split the representation string into the goal's data and create a new goal
                string[] parts = data.Split("|");
                ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));

                // Record how much has already been completed
                goal.SetAmountCompleted(int.Parse(parts[5]));

                // Add the goal to the _goals list
                _goals.Add(goal);
            }
        }
        Console.WriteLine();
    }
}