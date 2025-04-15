namespace EternalQuest
{

 public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        //todo:
    }
    public override void RecordEvent()
    {
        //todo:
        _isComplete = true;

    }
    public override bool IsComplete()
    {
        //todo:
        return _isComplete;

    }
    public override string GetStringRepresentation()
    {
        //todo:
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
    public void completeIt()
    {
        _isComplete = true;
    }
    public bool completed()
    {
        return _isComplete;
    }

}
}