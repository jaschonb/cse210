public class ReflectingActivity : Activity
{
    // Declare attributes
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _usedPrompts;
    private List<string> _usedQuestions;

    // Set the reflection activity's name, description, and fill the
    // _prompts list and _questions list with content
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _usedPrompts = new List<string>();

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        _usedQuestions = new List<string>();
    }

    // Run the reflection activity
    public void Run()
    {
        // Display the starting message and prompt
        DisplayStartingMessage();
        DisplayPrompt();

        // Allow the user time to think by pausing the program
        // until the user presses enter
        Console.Write("When you have something in mind, press enter to continue");
        Console.ReadLine();

        // Display the questions
        DisplayQuestions();

        // Display the ending message
        DisplayEndingMessage();
    }

    // Get a random prompt for the user to reflect
    public string GetRandomPrompt()
    {
        Random random = new Random();
        string selectedPrompt = "";

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

        // Set the selectedPrompt string to the prompt at the
        // specified index of the _prompts list
        selectedPrompt = _prompts[index];

        // Add selected prompt to the _usedPrompts list
        _usedPrompts.Add(_prompts[index]);

        // Remove the selected prompt from the _prompts list
        _prompts.Remove(_prompts[index]);

        // Return the selected prompt
        return selectedPrompt;
    }

    // Get a random question for the user to reflect
    public string GetRandomQuestion()
    {
        Random random = new Random();
        string selectedQuestion = "";

        // If the _questions list is empty, add the used questions back to
        // the _questions list and empty the _usedQuesitons list
        if (_questions.Count == 0)
        {
            for (int i = _usedQuestions.Count - 1; i >= 0; i--)
            {
                _questions.Add(_usedQuestions[i]);
                _usedQuestions.RemoveAt(i);
            }
        }

        // Select a random index from the _questions list
        int index = random.Next(_questions.Count);

        // Set the selectedQuestion string to the question at the
        // specified index of the _questions list
        selectedQuestion = _questions[index];

        // Add selected question to the _usedQuestions list
        _usedQuestions.Add(_questions[index]);

        // Remove the selected question from the _questions list
        _questions.Remove(_questions[index]);

        // Return the selected question
        return selectedQuestion;
    }

    // Display the prompt to the user
    public void DisplayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"----- {GetRandomPrompt()} -----");
        ShowSpinner(5);
    }

    // Display questions to the user
    public void DisplayQuestions()
    {
        // Record the current time and what the time will be
        // after the specified duration has passed
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());

        // Display questions to the console until the specified
        // duration has passed
        while (currentTime < futureTime)
        {
            // Update the current time
            currentTime = DateTime.Now;

            // Display a random quesiton
            Console.WriteLine();
            Console.WriteLine($"    {GetRandomQuestion()}");

            // Pause the program by showing a spinner for a few seconds
            // to allow the user time to reflect
            ShowSpinner(7);
        }
    }
}