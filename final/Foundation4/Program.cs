using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold each activity
        List<Activity> activities = new List<Activity>();

        // Create and store each activity
        activities.Add(new RunningActivity("Running", "03 Nov 2022", 30, 3));
        activities.Add(new BicycleActivity("Bicycling", "04 Nov 2022", 30, 13));
        activities.Add(new SwimmingActivity("Swimming", "05 Nov 2022", 30, 15));

        // Write the details and stats for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
    }
}