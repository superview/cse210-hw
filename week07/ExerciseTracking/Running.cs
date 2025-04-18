using System.Runtime.ConstrainedExecution;

public class Running : Activity
{
    //distance
    public double _distance;
    protected double _speed;
    protected double _pace;
    public Running(double distance, int minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }
    public override void GetSummary()
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        string date = _date.ToString("dd MMM yyyy");
        string activity = "Running";
        string distance = _distance.ToString();
        _speed = (_distance / _minutes) * 60;
        _pace = _minutes / _distance;

        Console.WriteLine($"{date} {activity} ({_minutes} min) - Distance {distance:F1} miles, Speed {_speed:F1} mph, Pace: {_pace:F2} min per mile");
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return _pace;

    }
}