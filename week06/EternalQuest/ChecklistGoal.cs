using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {

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
    public new string GetStringRepresentation()
    {
        return "ChecklistGoal:GetStringRepresentation stub";
    }
}