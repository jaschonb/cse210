public class Prompt
{
    // Create a list of strings to hold pre-determined prompts.
    public string[] _promptsList;

    // Retrieve and return a random prompt from the list "_promptsList".
    public String GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptsList.Count());
        Console.WriteLine(_promptsList[index]);
        return _promptsList[index];
    }
}