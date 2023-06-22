public class Reference
{
    // Attributes:
    //  _book - a string containing the book of the scripture's reference.
    //  _chapter - an integer containing the chapter of the scripture's reference.
    //  _verse - an integer containing the starting verse of the scripture's reference.
    //  _endVerse - an integer containing the ending verse of the scripture's reference
    //              (if applicable)
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Define a Reference object with the book, chapter, and verse specified.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    // Define a Reference object with the book, chapter, verse, and end verse specified.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Return the display text of the reference.
    public string GetDisplayText()
    {
        // If the Reference only has 1 verse, display accordingly.
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        // If the Reference has multiple verses, display accordingly.
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}