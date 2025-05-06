using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter their grade percentage.
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        char letter;       // The letter grade (A-F)
        string sign = "";  // The '+' or '-' modifier

        // Determine the base letter grade (A-F) using if-else
        if (percentage >= 90)
        {
            letter = 'A';
        }
        else if (percentage >= 80)
        {
            letter = 'B';
        }
        else if (percentage >= 70)
        {
            letter = 'C';
        }
        else if (percentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        // Add '+' or '-' modifiers for B, C, D grades based on the last digit
        // Do not allow '+' or '-' for 'A' (except A- for below 93) or 'F'.
        if (letter != 'A' && letter != 'F')
        {
            int lastDigit = percentage % 10; // get the last digit of the percentage
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special rule for 'A': allow A-, but no A+
        if (letter == 'A')
        {
            if (percentage < 93)
            {
                sign = "-";
            }
            else
            {
                sign = ""; // no sign for A (93-100%)
            }
        }

        // Special rule for 'F': no '+' or '-' ever
        if (letter == 'F')
        {
            sign = "";
        }

        // Print the full letter grade with sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Check if the student passed (>= 70%) and display message
        if (percentage >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("You failed the course.");
        }
    }
}
