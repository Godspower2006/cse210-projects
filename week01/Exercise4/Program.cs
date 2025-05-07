using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();
        
        // Prompt the user for numbers until they enter 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;
        while (true)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            
            // Try parsing the user input to an integer
            if (!int.TryParse(userInput, out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }
            
            // Stop if the user enters 0 (do not add 0 to the list)
            if (userNumber == 0)
            {
                break;
            }
            
            numbers.Add(userNumber);
        }
        
        // If no numbers were entered, inform the user and exit.
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }
        
        // Core Requirement 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        // Core Requirement 2: Compute the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        // Core Requirement 3: Find the largest number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        
        // Stretch Challenge Part 1: Find the smallest positive number
        int smallestPositive = int.MaxValue;
        bool foundPositive = false;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
                foundPositive = true;
            }
        }
        if (foundPositive)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }
        
        // Stretch Challenge Part 2: Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
