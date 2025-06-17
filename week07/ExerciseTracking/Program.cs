using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Running run = new Running(new DateTime(2022, 11, 3), 30, 3.0); // 3 miles in 30 min
        StationaryBicycle bike = new StationaryBicycle(new DateTime(2022, 11, 3), 30, 15.0); // 15 mph for 30 min
        Swimming swim = new Swimming(new DateTime(2022, 11, 3), 30, 20); // 20 laps

        // Add to list
        List<Activity> activities = new List<Activity> { run, bike, swim };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
