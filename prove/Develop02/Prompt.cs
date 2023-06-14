public class Prompt
{
    /* 
    This class deals with prompts for the journal
    Attributes:
        _promptsList: a list of strings that holds pre-determined prompts
    Methods:
        GetPrompt(): Retrieves a random prompt from the list of prompts
    */

    public List<String> _promptsList = new List<String>();

    public String GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptsList.Count);
        return _promptsList[index];
    }
}