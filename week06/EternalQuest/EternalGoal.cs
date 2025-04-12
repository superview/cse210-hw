namespace EternalQuest
{

    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, string points) : base(name, description, points)
        { }
        public new void RecordEvent()
        {
            //todo:

        }
        public new bool IsComplete()
        {
            //todo:
            return true;

        }
        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()}";
        }
    }
}