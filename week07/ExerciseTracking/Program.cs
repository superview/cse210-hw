using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Running r = new Running(12.2, 245);
        Running r2 = new Running(14.9, 205);
        Cycling c = new Cycling(18.4, 115);
        Cycling c2 = new Cycling(16.4, 125);
        Swimming s = new Swimming(24, 22);
        Swimming s2 = new Swimming(18, 24);
        activities.Add(r);
        activities.Add(r2);
        activities.Add(c);
        activities.Add(c2);
        activities.Add(s);
        activities.Add(s2);

        foreach(Activity a in activities)
        {
            a.GetSummary();
        }

    }
}