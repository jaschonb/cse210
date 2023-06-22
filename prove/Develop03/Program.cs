using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the Reference and Scripture objects used.
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scr1 = new Scripture(ref1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy paths.");

        // Display the scripture's reference and text to the screen.
        Console.WriteLine(scr1.GetDisplayText());

        // Prompt the user asking how many words he/she would like to hide at a time.
        Console.WriteLine("\nHow many words do you want to hide at a time?");
        string wordsToHide = Console.ReadLine();
        int intWordsToHide = int.Parse(wordsToHide);

        // Run the program until the user inputs 'quit' or until all the words of the
        // scripture are hidden.
        bool programRuns = true;
        while (programRuns)
        {
            // Clear the console so the user can't look back on previously unhidden words.
            Console.Clear();

            // Display the scripture's text, this time with the hidden words. Prompt for the
            // user's choice to quit or continue.
            Console.WriteLine(scr1.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string choice = Console.ReadLine();

            // If the user presses 'enter', check if there are available words to hide.
            // If so, hide X number of words, where X is defined earlier by the user.
            if (string.IsNullOrEmpty(choice))
            {
                if (!scr1.IsCompletelyHidden())
                {
                    scr1.HideRandomWords(intWordsToHide);
                }
            }
            // If the user inputs 'quit', stop the program by breaking the loop.
            else if (choice == "quit")
            {
                programRuns = false;
            }

            // Check to see if all the words are hidden. If true, display the completely hidden
            // scripture text and stop the program by breaking the loop.
            if (scr1.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scr1.GetDisplayText());
                Console.WriteLine("\nAll words are hidden, congrats!");
                programRuns = false;
            }
        }   
    }
}
