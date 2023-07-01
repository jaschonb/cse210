public class Activity
{
    // Declare attributes
    private string _name;
    private string _description;
    private int _duration;

    // This constructor just sets a temporary value for _duration
    // that will be changed by the user later.
    public Activity()
    {
        _duration = 0;
    }

    // Getter method for _name
    public string GetName()
    {
        return _name;
    }

    // Setter method for _name
    public void SetName(string name)
    {
        _name = name;
    }

    // Getter method for _description
    public string GetDescription()
    {
        return _description;
    }

    // Setter method for _description
    public void SetDescription(string description)
    {
        _description = description;
    }

    // Getter method for _duration
    public int GetDuration()
    {
        return _duration;
    }

    // Setter method for _duration
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Display the starting message. The message is the same for each activity,
    // but each activity's own description and names are used.
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome!");
        Console.WriteLine();
        Console.WriteLine($"We will now start the {_name}. {_description}.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like to do this activity?\n   > ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Great! We will do this activity for {_duration} seconds. Get ready!");
        ShowSpinner(5);
        Console.Clear();
    }

    // Display the ending message. The message is the same for each activity,
    // but each activity's own name and duration specified by the user is used. 
    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Great job!");
        ShowSpinner(3);
        Console.WriteLine($"You just completed the {_name}, which lasted for {_duration} seconds.");
        ShowSpinner(5);
        Console.Clear();
    }

    // Display a spinner for when the program is "loading"
    public void ShowSpinner(int seconds)
    {
        for (int i = 1; i <= seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    // Displays a countdown timer for a specified amount of seconds
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}