public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length) 
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Returns the number of comments in the video
    public int NumberOfComments()
    {
        return _comments.Count;
    }

    // Adds a comment to the _comments list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Lists each comment with the commenter's name
    public void ListComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"    {comment.GetName()} - {comment.GetText()}");
        }
    }

    // Returns the video title
    public string GetTitle()
    {
        return _title;
    }

    // Returns the video's author
    public string GetAuthor()
    {
        return _author;
    }

    // Returns the video's length in seconds
    public int GetLength()
    {
        return _length;
    }
}