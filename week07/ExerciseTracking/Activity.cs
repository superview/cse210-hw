public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;
    public Activity()
    {
        _date = DateTime.Now;
    }
    public abstract void GetSummary();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

}