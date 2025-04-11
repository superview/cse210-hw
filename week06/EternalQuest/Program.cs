using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        EternalGoal _eg = new EternalGoal("EGoal","This is a goal.", "12");
        Console.WriteLine(_eg.GetDetailsString());
        Console.WriteLine(_eg.GetStringRepresentation());

    }
}