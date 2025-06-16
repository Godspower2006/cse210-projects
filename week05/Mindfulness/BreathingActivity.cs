using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void Execute()
    {
        int cycleTime = 6; // One full breath cycle: 3 seconds in, 3 seconds out
        int cycles = Duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            ShowCountdown(3);
            Console.WriteLine();
        }
    }
}
