using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Test the base Assignment class on its own
            Console.WriteLine("=== Testing Assignment (base class) ===");
            Assignment baseAssignment = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(baseAssignment.GetSummary());
            // Expected output:
            //   Samuel Bennett - Multiplication

            Console.WriteLine();

            // 2. Test MathAssignment
            Console.WriteLine("=== Testing MathAssignment (derived class) ===");
            MathAssignment math1 = new MathAssignment(
                studentName: "Roberto Rodriguez",
                topic: "Fractions",
                textbookSection: "7.3",
                problems: "8-19"
            );
            // GetSummary() comes from Assignment
            Console.WriteLine(math1.GetSummary());
            // GetHomeworkList() is specific to MathAssignment
            Console.WriteLine(math1.GetHomeworkList());
            // Expected output:
            //   Roberto Rodriguez - Fractions
            //   Section 7.3 Problems 8-19

            Console.WriteLine();

            // 3. Test WritingAssignment
            Console.WriteLine("=== Testing WritingAssignment (derived class) ===");
            WritingAssignment writing1 = new WritingAssignment(
                studentName: "Mary Waters",
                topic: "European History",
                title: "The Causes of World War II"
            );
            // GetSummary() comes from Assignment
            Console.WriteLine(writing1.GetSummary());
            // GetWritingInformation() is specific to WritingAssignment
            Console.WriteLine(writing1.GetWritingInformation());
            // Expected output:
            //   Mary Waters - European History
            //   The Causes of World War II by Mary Waters

            Console.WriteLine();
        }
    }
}
