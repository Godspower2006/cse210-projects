// File: SimpleGoal.cs
using System;

namespace EternalQuest
{
    // Represents a goal that can be completed once
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false;
        }

        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                Console.WriteLine($"Good job! You earned {_points} points for completing '{_name}'.");
                return _points;
            }
            else
            {
                Console.WriteLine($"'{_name}' has already been completed.");
                return 0;
            }
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
        }

        public override void EditGoal()
        {
            base.EditGoal();
            Console.Write("Mark as complete? (yes/no): ");
            var input = Console.ReadLine();
            if (input?.Trim().ToLower() == "yes")
                _isComplete = true;
        }
    }
}
