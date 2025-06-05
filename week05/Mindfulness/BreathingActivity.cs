using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public override void Run()
    {
        Start();

        int cycles = Duration / 10; // Each breathing cycle takes about 10 seconds (5 in, 5 out)
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(5);
            Console.WriteLine();

            Console.Write("Now breathe out... ");
            ShowCountdown(5);
            Console.WriteLine();
        }

        End();
    }
}
