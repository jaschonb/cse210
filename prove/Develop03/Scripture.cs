public class Scripture
{
    // Attributes:
    //  _reference - stores the scripture reference assosiated with this scripture.
    //  _words - a list of Word objects, with each object being the individual
    //           words in the scripture's text.
    private Reference _reference;
    private List<Word> _words;

    // Define a Scripture object with given Reference object and scripture text.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Seperate the text into individual words in a list.
        string[] words = text.Split(" ");

        // Create individual Word objects for each word in the list.
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    // Hide X number of words where X is specified by the user.
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        bool validWord;

        // Calculate how many words remain unhidden.
        int remainingWords = _words.Count(w => !w.IsHidden());

        // Calculate how many words to hide. If there are fewer words than
        // what was specified than the user, the program will instead hide
        // the remaining words.
        int wordsToHide = Math.Min(numberToHide, remainingWords);

        // Iterate X number of times to hide a word, where X is the number
        // calculated in 'wordsToHide'.
        for (int i = 0; i < wordsToHide; i++)
        {
            // Set validWord to 'false' so the loop runs until true. This
            // way the program only hides words that are not yet hidden.
            validWord = false;
            while (!validWord)
            {
                // Select a random index and if it is valid (unhidden), hide
                // the word and set validWord to 'true' to escape the loop.
                int index = rand.Next(_words.Count);
                if (_words[index].IsHidden() == false)
                {
                    validWord = true;
                    _words[index].Hide();
                }
            }
        }
    }

    // Returns the scripture's reference and text.
    public string GetDisplayText()
    {
        string displayText = "";

        // Iterate through each Word object in '_words'.
        foreach (Word word in _words)
        {
            // Add the word's text to the display string.
            displayText += $"{word.GetDisplayText()} ";
        }

        // Return a string with the scripture's reference and text.
        return $"{_reference.GetDisplayText()} {displayText}";
    }

    // Check if all Words in '_words' are hidden.
    public bool IsCompletelyHidden()
    {
        // Iterate through each Word in '_words'.
        foreach (Word word in _words)
        {
            // If the program finds a word that isn't hidden, return false.
            if (!word.IsHidden())
            {
                return false;
            }
        }

        // If all words are hidden, return true.
        return true;
    }
}