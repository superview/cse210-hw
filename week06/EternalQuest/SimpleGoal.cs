public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        //todo:

    }
    public new void RecordEvent()
    {
        //todo:

    }
    public new bool IsComplete()
    {
        //todo:
        return _isComplete;

    }
    public new string GetStringRepresentation()
    {
        //todo:
        return $"{this.GetName()},{this.GetDescription()},{this.GetPoints()}";
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