using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Entry e = new Entry();
        Journal j = new Journal();
        Prompt p = new Prompt();
        string random_prompt = p.GetRandom();
        Console.WriteLine($"This is a random quote: {random_prompt}");
        p.Display();
    }
}