public class Word
{
    // Attributes:
    //  _text - a string containing the word's text.
    //  _isHidden - a bool that contains a value based on if the word
    //              is hidden (true) or not (false).
    private string _text;
    private bool _isHidden;

    // Define a Word object with given text.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word.
    public void Hide()
    {
        _isHidden = true;
    }

    // Show the word.
    public void Show()
    {
        _isHidden = false;
    }

    // Return whether or not the word is hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Return the display text of the word.
    public string GetDisplayText()
    {
        // If the word is hidden, set the text to underscores to show it is hidden.
        if (_isHidden == true)
        {
            string hiddenWord = "";
            
            // Replace each character in the word to maintain word length.
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenWord += "_";
            }

            // Return the hidden word.
            return hiddenWord;
        }
        // If the word isn't hidden yet, return the word.
        else
        {
            return _text;
        }
    }
}