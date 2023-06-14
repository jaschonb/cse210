public class Entry
{
    /* 
    This class deals with entries for the journal
    Attributes:
        _userEntry: stores the user's journal entry
        _date: stores the date of the entry
        _prompt: stores the prompt associated with the entry
    Methods:
        DisplayEntry(): prints the entry's date, prompt, and entry to the console
    */

    public string _userEntry;
    public string _date;
    public string _prompt;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_userEntry);
        Console.WriteLine();
    }
}