public class Running : Activity
{
    //distance
    public double _distance;
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
        double speed = (_distance / _minutes) * 60;
        double pace = _minutes / _distance;

        Console.WriteLine($"{date} {activity} ({_minutes} min) - Distance {distance:F1} miles, Speed {speed:F1} mph, Pace: {pace:F2} min per mile");
    }
}