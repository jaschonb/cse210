using System;
// using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store each event
        List<Event> events = new List<Event>();

        // Create and store new events in the list
        events.Add(new Lecture("Lecture", "Computer Science Informational Interview", "Learn about Ron's experience from studying Computer Science!", "April 26th, 2023", "3:15 pm", new Address("1234 Nimitz Dr.", "Oak Harbor", "Oregon", "United States of America"), "Ron Smith", 54));
        events.Add(new OutdoorGathering("Outdoor Gathering", "Summer BBQ", "Eat, drink, and be merry!", "July 19th, 2023", "6:00 pm", new Address("1234 Fairbank St.", "Rigby", "Idaho", "United States of America"), "Sunny"));
        events.Add(new Reception("Reception", "Jack and Jill's Wedding", "Come party with us!", "August 16th", "5:30 pm", new Address("3892 Periwinkle Ave.", "Layton", "Utah", "United States of America"), "jack@email.com"));

        // Write out the details of each event
        foreach (Event evt in events)
        {
            evt.WriteStandardDetails();
            Console.WriteLine();
            evt.WriteFullDetails();
            Console.WriteLine();
            evt.WriteShortDescription();
            Console.WriteLine();
        }
    }
}