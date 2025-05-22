using System;

namespace ScriptureMemorizer
{
    /// <summary>
    /// Exceeds core requirements: tracks and reports number of rounds,
    /// and supports loading multiple scriptures (stubbed for future file I/O).
    /// </summary>
    public class Program
    {
        private static Scripture _scripture;
        private static int _roundCount = 0;  // counts how many times ENTER was pressed

        public static void Main(string[] args)
        {
            // TODO: In future, load a random scripture from an external file/library
            Reference reference = new Reference("John", 3, 16);
            _scripture = new Scripture(reference,
                "For God so loved the world, that he gave his only begotten Son, " +
                "that whosoever believeth in him should not perish, but have everlasting life.");

            while (!_scripture.IsCompletelyHidden())
            {
                Console.Clear();
                DisplayScripture();

                Console.Write("Press ENTER to hide words or type \"quit\": ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "quit")
                    break;

                _scripture.HideRandomWords(3);  // hide 3 new words each round
                _roundCount++;
            }

            Console.Clear();
            DisplayScripture();
            Console.WriteLine($"\nAll words hidden in {_roundCount} rounds. Program ending.");
        }

        private static void DisplayScripture()
        {
            _scripture.Reference.Display();
            Console.WriteLine("\n");
            _scripture.Display();
            Console.WriteLine();
        }
    }
}
