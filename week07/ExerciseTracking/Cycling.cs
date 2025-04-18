public class Cycling : Activity
{
    protected double _speed;
    public Cycling(double speed, int minutes)
    {
        _speed = speed;
        _minutes = minutes;
    }
    public override void GetSummary()
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        string date = _date.ToString("dd MMM yyyy");
        string activity = "Cycling";
        string distance = (_speed * _minutes).ToString();
        double pace = (_minutes / _speed );

        Console.WriteLine($"{date} {activity} ({_minutes} min) - Distance {distance:F1} miles, Speed {_speed:F1} mph, Pace: {pace:F2} min per mile");
    }
    }
}