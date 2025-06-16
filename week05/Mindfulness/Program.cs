using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker();
    }

    static void GoalTracker()
    {
        string userChoice;
        do
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            userChoice = Console.ReadLine();

            Activity activity = null;
            switch (userChoice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Stay centered and mindful!\n");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please select a valid option.");
                    Thread.Sleep(1500);
                    continue;
            }

            if (activity != null)
            {
                activity.Run();
            }

        } while (userChoice != "4");
    }
}

/*
CREATIVITY COMMENT:
- Spinner animations use creative symbols and varying patterns.
- Duration input uses graceful error handling and default fallback.
- Each activity displays customized starting and ending messages.
- The program structure is modular and extendable for future activities.
- Enhanced prompts and user experience elements in each activity.
*/
