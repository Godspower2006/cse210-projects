// File: EternalGoal.cs
using System;

namespace EternalQuest
{
    // Represents a goal that continues to provide points indefinitely
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
            Console.WriteLine($"Nice work! You earned {_points} points for recording progress on '{_name}'.");
            return _points;
        }

        public override bool IsComplete()
        {
            // Eternal goals are never marked as complete
            return false;
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{_name}|{_description}|{_points}";
        }

        public override void EditGoal()
        {
            base.EditGoal();
        }
    }
}
