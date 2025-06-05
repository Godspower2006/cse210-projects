using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = GetDurationFromUser();
        _duration = duration;
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected int GetDurationFromUser()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int seconds) && seconds > 0)
            {
                return seconds;
            }
            else
            {
                Console.Write("Please enter a positive integer: ");
            }
        }
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
    }

    protected void ShowCountdown(int count)
    {
        for (int i = count; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public virtual void Run()
    {
        Start();
        // Derived classes implement their own behavior here.
        End();
    }

    protected int Duration => _duration;

    protected string Name => _name;

    protected string Description => _description;
}
