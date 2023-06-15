using System.IO;

public class Journal
{
    // Create a list of Entry objects representing the journal entries
    public List<Entry> _entries = new List<Entry>();

    // Go through each entry in the list "_entries" and call the DisplayEntry() method in
    // the Entry class. This writes all entries to the console.
    public void DisplayEntries()
    {
        Console.WriteLine("------------------------------- My Journal -------------------------------");
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        Console.WriteLine("--------------------------------------------------------------------------");
    }

    // Load entries from given external txt file by reading each line in the file
    // and seperating each line into the entry's date, prompt, and content.
    // Add loaded entries to the list "_entries".
    public void LoadFile()
    {
        // Find the file that the user enters and open it for reading.
        Console.Write("Please enter the file name: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        // Go through each line in the file and seperate it into the
        // entry's date, prompt, and content. This data is stored into
        // a temporary entry and placed in the list "_entries".
        foreach (string line in lines)
        {
            Entry tempEntry = new Entry();
            string[] parts = line.Split("~|~");
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            tempEntry._date = date;
            tempEntry._prompt = prompt;
            tempEntry._userEntry = entry;

            _entries.Add(tempEntry);
        }
        Console.WriteLine();
    }

    // Save current entries to a given external file by opening the file
    // for writing and writing the entry data to that file.
    public void SaveFile()
    {
        // Find the file that the user enters.
        Console.Write("Please enter the file name: ");
        string fileName = Console.ReadLine();

        // Clear the current file to avoid duplicates.
        File.WriteAllText(fileName, String.Empty);

        // Open the given file for writing.
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Write each entry to a single line in the given file.
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._userEntry}");
            }
        }
        // Clear the list "_entries" to avoid duplicates when displaying entries.
        _entries.Clear();

        // Add space for a cleaner look in terminal.
        Console.WriteLine();
    }

    // Add entry to the list "_entries".
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
}