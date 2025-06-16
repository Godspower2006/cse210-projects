using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Run()
    {
        DisplayStartMessage();
        Execute();
        DisplayEndMessage();
    }

    private void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        _duration = PromptDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    private void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    private int PromptDuration()
    {
        Console.Write("Enter duration in seconds: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result) && result > 0)
            {
                return result;
            }
            Console.Write("Please enter a positive integer: ");
        }
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b ");
            index = (index + 1) % spinner.Length;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected int Duration => _duration;

    protected abstract void Execute();
}
