using System;

class Program
{
    static void Main(string[] args)
    {
        // Display a welcome message
        DisplayWelcome();

        // Prompt for and retrieve the user's name and favorite number
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        // Compute the square of the user's number
        int squaredNumber = SquareNumber(userNumber);

        // Display the result
        DisplayResult(userName, squaredNumber);
    }

    // Displays the welcome message.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Prompts the user for their name and returns it.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Prompts the user for their favorite number and returns it as an integer.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Accepts an integer and returns its square.
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Displays the user's name along with the squared number.
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
