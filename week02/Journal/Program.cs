using System;
using System.Collections.Generic;

namespace JournalApp;

class Program
{
    static void Main(string[] args)
    {
        // Creative features: delimiter-escaping for robust file I/O, in-app resume summary
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Show project resume summary (creative feature)");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string prompt = GetRandomPrompt(prompts);
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    journal.AddEntry(new Entry(prompt, response, date));
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "5":
                    Console.WriteLine("\nResume Summary:");
                    Console.WriteLine("This journal program demonstrates object-oriented principles with Journal and Entry abstractions.");
                    Console.WriteLine("It includes file save/load functionality, random prompts, and a creative feature displaying this summary.");
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose 1-6.");
                    break;
            }
        }
        Console.WriteLine("Goodbye!");
    }

    static string GetRandomPrompt(List<string> prompts)
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}
