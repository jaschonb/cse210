public class journal
{
    /*
    This class deals with the journal
    Attributes:
        _entries: a list of Entry objects representing the journal entries
    Methods:
        DisplayEntries(): Displays all Entry objects
        LoadFile(): loads entries from an external text file and fills the _entries list
        SaveFile(): saves the journal entries to a file
        AddEntry(): adds an entry to the journal
    */

    public List<Entry> _entries = new List<Entry>();

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void LoadFile()
    {

    }

    public void SaveFile()
    {

    }

    public void AddEntry(Entry newEntry)
    {

    }
}