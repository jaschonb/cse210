using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Journal object.
        Journal theJournal = new Journal();

        // Create a list "menuChoices" to store the options in the menu.
        string[] menuChoices = {"Write", "Display", "Load", "Save", "Quit"};

        // Create a list "prompts" to store the pre-determined prompts for the entries.
        string[] prompts = {"What was the best thing that happened to you today?",
                            "What is something that made you laugh today?",
                            "Who made your day better?",
                            "What is one thing you want to remember from today?",
                            "What made today unique?",
                            "How did you see the Lord's hand in your life today?",
                            "What are you thankful for today?"};
        
        // Create a boolean variable to determine if the program is running or not.
        Boolean runProgram = true;
        while (runProgram == true)
        {
            // Display the menu.
            Console.WriteLine("Please select one of the following choices:");
            for (int i=0; i < menuChoices.Count(); i++)
            {
                Console.WriteLine($"{i+1}. {menuChoices[i]}");
            }

            // Recieve user input to select from menu.
            String userChoice = Console.ReadLine();
            Console.WriteLine();

            // If / else if statement for each option on the menu.
            if (userChoice == "1")
            {
                // Write entry option. 
                // Create new Date, Entry, and Prompt objects.
                DateTime theCurrentTime = DateTime.Now;
                Entry newEntry = new Entry();
                Prompt newPrompt = new Prompt();

                // Save the Date and store it in the Entry.
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;

                // Prompt the user if they would like a random or custom prompt.
                Console.WriteLine("Would you like to write about?");
                Console.WriteLine("1. Random prompt");
                Console.WriteLine("2. Custom prompt");
                string promptType = Console.ReadLine();
                Console.WriteLine();

                // If promptType == "1", Retrieve a random prompt from the list of prompts.
                if (promptType == "1")
                {
                    newPrompt._promptsList = prompts;
                    newEntry._prompt = newPrompt.GetPrompt();
                }
                // If promptType == "2", Prompt the user to input a custom prompt.
                else if (promptType == "2")
                {
                    Console.WriteLine("Please enter your custom prompt:");
                    newEntry._prompt = Console.ReadLine();
                    Console.WriteLine("Enter your response here:");
                }
                
                // Read the user's response to the prompt.
                newEntry._userEntry = Console.ReadLine();
                Console.WriteLine();

                // Add the new entry to the journal object.
                theJournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                // Display journal option.
                theJournal.DisplayEntries();
            }
            else if (userChoice == "3")
            {
                // Load journal file option.
                theJournal.LoadFile();
            }
            else if (userChoice == "4")
            {
                // Save journal file option.
                theJournal.SaveFile();
            }
            else if (userChoice == "5")
            {
                // Quit program option.
                // Set "runProgram" to false, stopping the while loop.
                runProgram = false;
            }
            else
            {
                // If the user inputs anything other than a number between 1 and 5,
                // print an error message and repeat the loop for them to try again.
                Console.WriteLine("Invalid input. Please input a number between 1 and 5\n");
            }
        }
    }
}