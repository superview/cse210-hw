using System.Text.Json.Serialization;

namespace EternalQuest
{

    public abstract class Goal
    {
        public string _shortName { get; set; }
        public string _description { get; set; }
        public string _points { get; set; }
        [JsonConstructor]
        public Goal(string name, string description, string points)
        {
            _shortName = name;
            _description = description;
            _points = points;

        }
        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public string GetDetailsString()
        {
            return $"Name: {_shortName}\nDesc: {_description}\nPoints: {_points}";
        }
        public virtual string GetStringRepresentation()
        {
            return "StringgyThingy";
        }
        public string GetName()
        {
            return _shortName;
        }
        public string GetDescription()
        {
            return _description;
        }
        public string GetPoints()
        {
            return _points;
        }
        public string GetCheckbox()
        {
            if(IsComplete())
            {
                return "[X]";
            }
            else
            {
                return "[ ]";
            }

        }
    }
}