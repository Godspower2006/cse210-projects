using System;

namespace Homework
{
    // Base class: stores student name and topic, with a GetSummary() method.
    public class Assignment
    {
        // These are private so that outside code (including derived classes) cannot
        // directly manipulate them. We'll expose studentName via a public getter.
        private string _studentName;
        private string _topic;

        // Constructor requires studentName and topic.
        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        // Public getter for _studentName, so derived classes can use it.
        public string GetStudentName()
        {
            return _studentName;
        }

        // Public getter for _topic, if needed by derived classes.
        public string GetTopic()
        {
            return _topic;
        }

        // Returns "<studentName> - <topic>"
        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }
}
