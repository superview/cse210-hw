public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;
    public Activity()
    {
        _date = DateTime.Now;
    }
    public abstract void GetSummary();

}