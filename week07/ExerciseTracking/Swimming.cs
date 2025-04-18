public class Swimming : Activity
{
    protected int _laps;
    protected double _distance;
    protected double _pace;
    protected double _speed;
    public Swimming(int laps, int min)
    {
        _laps = laps;
        _minutes = min;
    }
    public override void GetSummary()
    {
        string date = _date.ToString("dd MMM yyyy");
        string activity = "Swimming";
        _distance = _laps * 50.0 / 1000.0;
        _speed = (_distance / _minutes) * 60;
        _pace = _minutes / _distance;

        Console.WriteLine($"{date} {activity} ({_minutes} min) - Distance {_distance:F1} miles, Speed {_speed:F1} mph, Pace: {_pace:F2} min per mile");
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return _pace;
    }
    public override double GetSpeed()
    {
        return _speed;
    }

}