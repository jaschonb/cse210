public class Entry
{
    // Store the content of the user's entry.
    public string _userEntry;

    // Store the date of the user's entry.
    public string _date;

    // Store the prompt of the user's entry.
    public string _prompt;

    // Write the entry's date, prompt, and content to the console.
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_userEntry);
        Console.WriteLine();
    }
}