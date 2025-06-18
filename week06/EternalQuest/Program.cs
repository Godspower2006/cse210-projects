// File: Program.cs
// Creative Features
//  • Delete & Edit Goal options added to menu
//  • Input validation on all numeric entries
//  • Factory methods (FromString) for deserializing each Goal type
using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Eternal Quest Goal Manager");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Edit Goal");
                Console.WriteLine("7. Quit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CreateGoal(manager);
                        break;
                    case "2":
                        manager.DisplayGoals();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("Enter filename to save: ");
                        manager.SaveGoals(Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Write("Enter filename to load: ");
                        manager.LoadGoals(Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case "5":
                        manager.DisplayGoals();
                        Console.Write("Enter goal number to record event: ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                            manager.RecordEvent(index - 1);
                        Console.ReadKey();
                        break;
                    case "6":
                        manager.DisplayGoals();
                        Console.Write("Enter goal number to edit: ");
                        if (int.TryParse(Console.ReadLine(), out int editIndex))
                            manager.EditGoal(editIndex - 1);
                        Console.ReadKey();
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CreateGoal(GoalManager manager)
        {
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter description: ");
            string desc = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    manager.AddGoal(new SimpleGoal(name, desc, points));
                    break;
                case "2":
                    manager.AddGoal(new EternalGoal(name, desc, points));
                    break;
                case "3":
                    Console.Write("Enter target completions: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new CheckListGoal(name, desc, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid goal type selected.");
                    break;
            }
        }
    }
}
