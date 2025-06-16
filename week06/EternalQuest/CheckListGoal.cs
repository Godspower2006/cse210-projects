// File: CheckListGoal.cs
using System;

namespace EternalQuest
{
    // Represents a checklist goal that must be completed a number of times to earn a bonus
    public class CheckListGoal : Goal
    {
        private int _targetCount;
        private int _currentCount;
        private int _bonus;

        public CheckListGoal(string name, string description, int points, int targetCount, int bonus)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _currentCount = 0;
            _bonus = bonus;
        }

        public override int RecordEvent()
        {
            if (_currentCount < _targetCount)
            {
                _currentCount++;
                int earned = _points;

                if (_currentCount == _targetCount)
                {
                    earned += _bonus;
                    Console.WriteLine($"Congratulations! You've completed the checklist for '{_name}' and earned a bonus of {_bonus} points!");
                }
                else
                {
                    Console.WriteLine($"Good job! You've completed {_currentCount}/{_targetCount} for '{_name}'.");
                }

                return earned;
            }
            else
            {
                Console.WriteLine($"'{_name}' checklist is already complete.");
                return 0;
            }
        }

        public override bool IsComplete()
        {
            return _currentCount >= _targetCount;
        }

        public override string GetStringRepresentation()
        {
            return $"CheckListGoal|{_name}|{_description}|{_points}|{_targetCount}|{_bonus}|{_currentCount}";
        }

        public override void EditGoal()
        {
            base.EditGoal();
            Console.Write("Enter new target count: ");
            _targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter new bonus points: ");
            _bonus = int.Parse(Console.ReadLine());
        }
    }
}
