public class Swimming : Activity
{
    protected int _laps;
    public Swimming(int laps, int min)
    {
        _laps = laps;
        _minutes = min;
    }
    public override void GetSummary()
    {
        string date = _date.ToString("dd MMM yyyy");
        string activity = "Swimming";
        double distance = _laps * 50.0 / 1000.0;
        double speed = (distance / _minutes) * 60;
        double pace = _minutes / distance;

        Console.WriteLine($"{date} {activity} ({_minutes} min) - Distance {distance:F1} miles, Speed {speed:F1} mph, Pace: {pace:F2} min per mile");
    }

}