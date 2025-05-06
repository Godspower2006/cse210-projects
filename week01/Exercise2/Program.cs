using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int percent) || percent < 0 || percent > 100)
        {
            Console.WriteLine("Please enter a valid percentage between 0 and 100.");
            return;
        }

        string letter;
        if (percent >= 90)
            letter = "A";
        else if (percent >= 80)
            letter = "B";
        else if (percent >= 70)
            letter = "C";
        else if (percent >= 60)
            letter = "D";
        else
            letter = "F";

        string sign = "";
        int lastDigit = percent % 10;

        if (letter != "F")
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
        }

        // No A+ grades
        if (letter == "A" && sign == "+")
            sign = "";

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
            Console.WriteLine("Congratulations, you passed!");
        else
            Console.WriteLine("Better luck next time!");
    }
}
