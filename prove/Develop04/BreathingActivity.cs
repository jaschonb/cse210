public class BreathingActivity : Activity
{
    // Set the BreathingActivity's name and description
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    // Run the breathing activity
    public void Run()
    {
        // Display the starting message and clear the console.
        DisplayStartingMessage();
        Console.Clear();

        // Record the current time and what the time will be after the specified
        // duration has passed
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());

        // Display a series of messages to guide your breathing until the specified
        // duration has passed
        while (currentTime < futureTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(6);
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }
        // Display the ending message
        DisplayEndingMessage();
    }
}