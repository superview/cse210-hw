public class Cycling : Activity
{
    protected double _speed;
    protected double _distance;
    private double _pace;
    public Cycling(double speed, int minutes)
    {
        _speed = speed;
        _minutes = minutes;
    }
    public override void GetSummary()
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        string date = _date.ToString("dd MMM yyyy");
        string activity = "Cycling";
        _distance = (_speed * _minutes / 60);
        _pace = (_minutes / _speed);

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