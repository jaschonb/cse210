using System;

class Program
{
    static void Main(string[] args)
    {
        string[] menuChoices = {"Write", "Display", "Load", "Save", "Quit"};
        
        Console.WriteLine("Please select one of the following choices:");

        for (int i=0; i < menuChoices.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {menuChoices[i]}");
        }

        String userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            Entry newEntry = new Entry();
            newEntry._date = dateText;
            
        }

    }
}