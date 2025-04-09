using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        ListingActivity _la = new ListingActivity();
        // _la.ShowSpinner(10);
        // _la.ShowCountDown(10);
        _la.GetRandomPrompt();
    }
}