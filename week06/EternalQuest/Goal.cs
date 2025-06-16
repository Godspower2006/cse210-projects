using System;

namespace EternalQuest
{
    // Base class for all goals
    public abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;

        public string Name => _name;
        public string Description => _description;
        public int Points => _points;

        protected Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        // Abstract method to record an event
        public abstract int RecordEvent();

        // Abstract method to check if the goal is complete
        public abstract bool IsComplete();

        // Get details string with status indicator
        public virtual string GetDetailsString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {_name}: {_description}";
        }

        // Get string representation for saving
        public abstract string GetStringRepresentation();

        // Virtual method for editing a goal (creative extension)
        public virtual void EditGoal()
        {
            Console.Write("Enter new name (leave blank to keep current): ");
            var newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName)) _name = newName;

            Console.Write("Enter new description (leave blank to keep current): ");
            var newDesc = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newDesc)) _description = newDesc;

            Console.Write("Enter new point value (leave blank to keep current): ");
            var newPts = Console.ReadLine();
            if (int.TryParse(newPts, out int pts)) _points = pts;
        }
    }
}
