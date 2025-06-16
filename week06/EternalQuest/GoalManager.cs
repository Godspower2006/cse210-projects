// File: GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    // Manages all goals and handles saving, loading, and displaying goal-related information
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordEvent(int index)
        {
            if (index >= 0 && index < _goals.Count)
            {
                int earned = _goals[index].RecordEvent();
                _score += earned;
                Console.WriteLine($"Points earned: {earned}, Total score: {_score}");
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        public void DisplayGoals()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {_goals[i].GetType().Name} - {_goals[i].GetStringRepresentation()}");
            }
            Console.WriteLine($"\nCurrent Score: {_score}\n");
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }

        public void LoadGoals(string filename)
        {
            if (File.Exists(filename))
            {
                _goals.Clear();
                string[] lines = File.ReadAllLines(filename);
                _score = int.Parse(lines[0]);
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool complete = bool.Parse(parts[4]);
                            SimpleGoal simple = new SimpleGoal(name, desc, points);
                            if (complete) simple.RecordEvent(); // mark as complete
                            _goals.Add(simple);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, desc, points));
                            break;
                        case "CheckListGoal":
                            int target = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            int current = int.Parse(parts[6]);
                            CheckListGoal checklist = new CheckListGoal(name, desc, points, target, bonus);
                            while (checklist.IsComplete() == false && current-- > 0)
                                checklist.RecordEvent();
                            _goals.Add(checklist);
                            break;
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("Save file not found.");
            }
        }

        public void EditGoal(int index)
        {
            if (index >= 0 && index < _goals.Count)
            {
                _goals[index].EditGoal();
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        public int GetScore() => _score;
    }
}
