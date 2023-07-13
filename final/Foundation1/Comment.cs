public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Returns the commenter's name
    public string GetName()
    {
        return _name;
    }

    // Returns the comment's text
    public string GetText()
    {
        return _text;
    }
}