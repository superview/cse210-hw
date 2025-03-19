using System;
using System.IO;

public class CsharpDates
{
    public void Display()
    {
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine(currentDateTime);
        string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine("Current date and time: " + formattedDateTime);
        Console.WriteLine(currentDateTime);
    }
}