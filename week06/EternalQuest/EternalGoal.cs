namespace EternalQuest
{

    public class EternalGoal : Goal
    {
        private bool _isComplete = false;
        public EternalGoal(string name, string description, string points) : base(name, description, points)
        { 
        }
        public override void RecordEvent()
        {
            _isComplete = true;
        }
        public override bool IsComplete()
        {
            return _isComplete;
        }
        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()}";
        }
    }
}