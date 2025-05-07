using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        
        // Outer loop: continue playing as long as the user says "yes"
        do
        {
            // Generate a new magic number each game
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!");

            // Loop until the correct guess
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                // Increment guess count whether parse succeeds or fails
                string input = Console.ReadLine();
                guessCount++;

                // Validate input
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid integer.");
                    continue;
                }

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} {(guessCount == 1 ? "try" : "tries")}!");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().Trim().ToLower();

            Console.WriteLine();  // blank line before next game or exit
        }
        while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}
