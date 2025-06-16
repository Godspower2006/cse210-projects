using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void Execute()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int itemCount = 0;

        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"\nYou listed {itemCount} items!");
    }
}
