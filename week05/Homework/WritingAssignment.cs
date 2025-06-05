using System;

namespace Homework
{
    // WritingAssignment also inherits from Assignment
    public class WritingAssignment : Assignment
    {
        private string _title;   // e.g. "The Causes of World War II"

        // Constructor: call base(studentName, topic) for the common fields.
        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic)
        {
            _title = title;
        }

        // Returns "<title> by <studentName>"
        // We need studentName, so we call GetStudentName() from the base class.
        public string GetWritingInformation()
        {
            return $"{_title} by {GetStudentName()}";
        }
    }
}
