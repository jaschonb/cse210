public class ListingActivity : Activity
{
    // Declare attributes
    private int _count;
    private List<string> _prompts;
    private List<string> _usedPrompts;
    private List<string> _responses;

    // Set the listing activity's name, description, and fill the 
    // _prompts list with prompts
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        // Set the counter to 0
        _count = 0;

        // Create an empty list of strings to store the used prompts
        _usedPrompts = new List<string>();
    }

    // Run the listing activity
    public void Run()
    {
        // Display the starting message and get a random prompt
        DisplayStartingMessage();
        GetRandomPrompt();

        // Declare a list for the user to place responses in
        _responses = new List<string>();

        // Record the current time and what the time will be after the specified
        // duration has passed
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());

        // Allow user to list as many things as they can until 
        // the specified duration passes
        while (currentTime < futureTime)
        {
            if (Console.KeyAvailable)
            {
                // Add each response to the responses list
                _responses.Add(Console.ReadLine());

                // Increase the count to keep track of how many things the user has listed
                _count++;
            }
            
            // Update the current time
            currentTime = DateTime.Now;
        }

        // Display how many things the user listed
        Console.WriteLine($"\nYou listed {_count} things!");

        // Pause the program for a few seconds and display the ending message
        ShowSpinner(3);
        DisplayEndingMessage();
    }

    // Get and display a random prompt for the user
    public void GetRandomPrompt()
    {
        Random random = new Random();

        // If the _prompts list is empty, add the used prompts back to 
        // the _prompts list and empty the _usedPrompts list
        if (_prompts.Count == 0)
        {
            for (int i = _usedPrompts.Count - 1; i >= 0; i--)
            {
                _prompts.Add(_usedPrompts[i]);
                _usedPrompts.RemoveAt(i);
            }
        }

        // Select a random index from the _prompts list
        int index = random.Next(_prompts.Count);

        // Write the prompt at the selected index to the console
        Console.WriteLine(_prompts[index]);

        // Add the prompt to the _usedPrompts list and remove it
        // from the _prompts list
        _usedPrompts.Add(_prompts[index]);
        _prompts.Remove(_prompts[index]);

        // Pause the program for a few seconds by showing the spinner
        ShowSpinner(5);
    }

    // Return the list of responses
    public List<string> GetListFromUser()
    {
        return _responses;
    }
}