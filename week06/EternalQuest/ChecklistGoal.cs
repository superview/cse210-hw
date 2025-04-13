using System.ComponentModel;

namespace EternalQuest
{

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public new void RecordEvent()
    {

    }
    public new bool IsComplete()
    {
        return false;
    }
    public new string GetDetailsString()
    {
        return "ChecklistGoal:GetDetailsString stub";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()},{this.GetTarget()},{this.GetBonus()}";
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