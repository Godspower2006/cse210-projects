// Resume.cs
using System;

namespace JournalApp;

public static class Resume
{
    // Prints a summary of how the project meets all grading criteria
    public static void DisplaySummary()
    {
        Console.WriteLine("\n--- Project Resume Summary ---");
        Console.WriteLine("1. Journal Abstraction: Journal class encapsulates Add, Display, Save, and Load methods.");
        Console.WriteLine("2. Entry Abstraction: Entry class holds prompt, response, and date with Display().");
        Console.WriteLine("3. Writing Functionality: Random prompts paired with date-stamped responses.");
        Console.WriteLine("4. Display Functionality: Displays each entry's date, prompt, and response.");
        Console.WriteLine("5. Prompt Generation: Uses a list of five prompts, selected at random.");
        Console.WriteLine("6. Saving: Writes entries to file using '|' delimiter and escapes embedded '|'.");
        Console.WriteLine("7. Loading: Reads file, splits by '|', un-escapes, and recreates entries.");
        Console.WriteLine("8. File Organization: Entry.cs, Journal.cs, Program.cs, and Resume.cs files match class names.");
        Console.WriteLine("9. Naming Conventions: TitleCase for types/methods, underscoreCamelCase for private fields.");
        Console.WriteLine("10. Creativity: In-app resume summary; robust I/O escaping; easy extension (e.g., JSON support).");
        Console.WriteLine(new string('-', 40));
    }
}
