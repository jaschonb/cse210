using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear the console and set the choice variable
        Console.Clear();
        string choice = "";

        // Repeat the program until the user selects "Quit"
        while (choice != "4")
        {
            // Write the program's menu
            Console.WriteLine("Welcome to the mindfulness program! Please select an activity:");
            Console.WriteLine("     1. Breathing Activity");
            Console.WriteLine("     2. Listing Activity");
            Console.WriteLine("     3. Reflecting Activity");
            Console.WriteLine("     4. Quit");;

            // Recieve user input for the menu selection
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                // If user chooses 1, run the breathing activity
                BreathingActivity ba = new BreathingActivity();
                ba.Run();
            }
            else if (choice == "2")
            {
                // If user chooses 2, run the listing activity
                ListingActivity la = new ListingActivity();
                la.Run();
            }
            else if (choice == "3")
            {
                // If user chooses 3, run the reflection activity
                ReflectingActivity ra = new ReflectingActivity();
                ra.Run();
            }

            // If the user types anything other than 1, 2, or 3, the program stops.
        }
    }
}