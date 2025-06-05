using System;

namespace Homework
{
    // MathAssignment inherits from Assignment
    public class MathAssignment : Assignment
    {
        private string _textbookSection;   // e.g. "7.3"
        private string _problems;          // e.g. "3-10, 20-21"

        // Constructor: we must call base(studentName, topic) to set those fields.
        public MathAssignment(
            string studentName,
            string topic,
            string textbookSection,
            string problems
        ) : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        // Returns "Section <textbookSection> Problems <problems>"
        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }
    }
}
