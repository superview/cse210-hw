using System.ComponentModel;

namespace EternalQuest
{

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete = false;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public new string GetDetailsString()
    {
        return "ChecklistGoal:GetDetailsString stub";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()},{this.IsComplete()},{this.GetTarget()},{this.GetBonus()}";
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
}
}